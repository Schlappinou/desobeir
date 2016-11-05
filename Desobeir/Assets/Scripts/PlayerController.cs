using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject X00;
    public GameObject X10;
    public GameObject X01;

    Vector3 X;
    Vector3 Y;
    Vector3 YpX;
    float xX;
    float yY;

    public float Speed;
    Vector2 LastDep;

    public AnimationCurve velocity;
    float velocityT;

    public LayerMask mask;

    public float lampda;

    // Use this for initialization
    void Start () {
        X = X10.transform.position - X00.transform.position;
        Y = X01.transform.position - X00.transform.position;
        X = X.normalized;
        Y = Y.normalized;

        YpX = Vector3.Project(Y, X);


        xX = Vector3.Dot((new Vector3(1, 0, 0)).normalized, X);
        yY = Vector3.Dot((new Vector3(0, 1, 0)).normalized, Y) *2;

        velocityT = 100.0f;
    }
	
    float signe(float f)
    {

        if(f == 0)
        {
            return 0;
        }
        if(f < 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }

        
    }

    float Pmax(float f, float a)
    {
        if (Mathf.Abs(f) < Mathf.Abs(a))
        {
            return f;
        }
        else
        {
            return a;
        }

    }

    Vector3 CanIPass(Vector3 Npos)
    {
        RaycastHit2D Lasthit;
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position + Npos, -1 * Npos, Npos.magnitude,mask);
        float dis = Npos.magnitude;
        if (hits.Length <= 0 )
        {
            return (Npos);
        }
        Lasthit = hits[0];
        bool b = true;

        foreach(RaycastHit2D hit in hits)
        {
            Debug.Log("yo"+Time.time);

            if (hit.distance > 0)
            {
                Lasthit = hit;
                b = false;

                dis = Npos.magnitude - hit.distance ;
                //dis = signe(Npos.magnitude) * lampda;
                Debug.Log("what " + hit.distance + " : " + Npos.magnitude + " " + dis);


            }
            else
            {
                Debug.Log("ok " + hit.distance);
            }
        }
        if( b )
        {
            return (Npos );
        }
        else
        {
            velocityT = 100f;
            return (Npos - Npos.normalized *Pmax(  (Lasthit.distance + lampda),Npos.magnitude));
        }

        

    }

   /* Vector3 CanIPass2(Vector3 Npos)
    {
        Vector3 PX;
        Vector3 PY;

        Vector3 x = new Vector3( 1, 0, 0);
        Vector3 y = new Vector3( 0, 1, 0);

        float Xpx = Vector3.Dot(x,X);
        float Xpy = Vector3.Dot(x,Y);
        float Ypx = Vector3.Dot(y,X);
        float Ypy = Vector3.Dot(y,Y);

        PX = Xpx * Vector3.Project(Npos, x) + Xpy * Vector3.Project(Npos, y);
        PY = Ypx * Vector3.Project(Npos, x) + Ypy * Vector3.Project(Npos, y);

        Debug.Log("test " + PX +" "+PY+" "+ Npos+" "+(PX + PY == Npos)+" " );

        return Npos;
    }*/

	// Update is called once per frame
	void Update () {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Vector3 NDep;
        //transform.position += Speed * (H * X + V * Y) * Time.deltaTime;
        if(H == 0 && V == 0)
        {
            //gestion de l'inertie !!!
            NDep = LastDep * velocity.Evaluate(velocityT);
        }
        else
        {
            //mouvement + init de l'inertie
            NDep = Speed * (xX * V * X + -1 * yY * H * Y) * Time.deltaTime;
            LastDep = NDep;
            velocityT = 0.0f;
        }

        NDep = CanIPass(NDep);
        // mise à jour de la position;
        transform.position += NDep;


        velocityT += Time.deltaTime;
    }
}
