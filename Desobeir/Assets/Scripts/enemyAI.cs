using UnityEngine;
using System.Collections;

public class enemyAI : Interactible
{

    public SpriteRenderer rend;
    public float lampda;
    public float Speed;
    public LayerMask mask;
    public float obeissance;

    float H;
    float V;
    // Use this for initialization
    void Start()
    {
        if (rend == null)
        {
            rend = GetComponent<SpriteRenderer>();
        }

        VcT = 0.0f;
        V = 1.0f;

    }

    public override void Interaction()
    {
        GameManager.instance.addJauge(obeissance);
        PlayerController.instance.attaque();
        StartCoroutine( Die() );

    }
    IEnumerator  Die()
    {

        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);

    }

    float signe(float f)
    {

        if (f == 0)
        {
            return 0;
        }
        if (f < 0)
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
        Npos = CanIPass2(Npos);
        return CanIPass2(Npos);


    }

    Vector3 CanIPass2(Vector3 Npos)
    {
        RaycastHit2D Lasthit;
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position + Npos, -1 * Npos, Npos.magnitude, mask);
        float dis = Npos.magnitude;
        if (hits.Length <= 0)
        {
            return (Npos);
        }
        Lasthit = hits[0];
        bool b = true;

        foreach (RaycastHit2D hit in hits)
        {

            if (hit.distance > 0)
            {
                Lasthit = hit;
                b = false;

                dis = Npos.magnitude - hit.distance;
                dis = signe(Npos.magnitude) * lampda;
            }
        }
        if (b)
        {
            return (Npos);
        }
        else
        {
            V = -1.0f * V;
            Vector2 LH = Lasthit.normal * (Lasthit.distance);
            return (Npos - new Vector3(LH.x, LH.y, 0));
        }

    }

    float normalfloat(float a)
    {
        if (a < 0)
        {
            return -1.0f;
        }
        else if (a > 0)
        {
            return 1.0f;
        }
        else
        {
            return 0.0f;
        }
    }

    public AnimationCurve Vc;
    float VcT;

    // Update is called once per frame
    void Update()
    {

        //Vector2 pl = instance.transform.position;
        //Vector2 mb = transform.position;
        Debug.Log(" perso :" + PlayerController.instance.transform.position.y + " mob :" + transform.position.y);
        Debug.Log(" perso :" + PlayerController.instance.transform.position.x + " mob :" + transform.position.x);

        //if (Vector2.Dot(PlayerController.instance.Y ,PlayerController.instance.transform.position) - Vector2.Dot(PlayerController.instance.Y, transform.position) > 0 )
        if (PlayerController.instance.transform.position.y > transform.position.y + lampda)
        {
            rend.sortingOrder = 5;
        }
        else
        {
            rend.sortingOrder = 3;
        }


        if (Random.Range(0.0f, 1.0f) > 0.9f)
        {
            V = V * -1.0f;
        }

        // normalfloat(Random.Range(-1.0f,1.0f));
        H = Vc.Evaluate(VcT);//normalfloat(Random.Range(-1.0f,1.0f));

        //H = (H * 2 + LastH) / 3;
        //V = (V * 2 + LastV) / 3;
        VcT += Time.deltaTime;
        Vector3 NDep;
        //transform.position += Speed * (H * X + V * Y) * Time.deltaTime;

        //mouvement + init de l'inertie
        NDep = Speed * (PlayerController.instance.xX * V * PlayerController.instance.X + -1 * PlayerController.instance.yY * H * PlayerController.instance.Y) * Time.deltaTime;



        NDep = CanIPass(NDep);
        // mise à jour de la position;
        transform.position += NDep;

    }
}
