using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Movespeed = 4;
    public float JumpForce = 15.6f;

    public Rigidbody2D _rigid;
    public SpriteRenderer sr;
    public GameObject ItemInHand;
    public GameObject ItemInHand2;

    public Animator anim;
    public GameObject playerfeet;

    public bool CanJump;
    public bool CanSwim;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Movespeed;

        if (_rigid.velocity.magnitude <= 0)
        {

            anim.SetBool("Walk", false);


        }

        if (!CanJump)
        {
            anim.SetBool("JF", false);
        }


        if (Input.GetKeyDown("space"))
        {
            if (CanJump)
            {
                _rigid.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                anim.SetBool("JF", true);
            }
        }

        if (Input.GetKey("space"))
        {
            if (CanSwim)
            {
                _rigid.AddForce(new Vector2(0, JumpForce / 3), ForceMode2D.Impulse);
                anim.SetBool("JF", true);
            }
        }

        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
            ItemInHand.SetActive(false);
            ItemInHand2.SetActive(true);
                sr.flipX = true;
                 anim.SetBool("Walk", true);
          }

            if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            {
                 ItemInHand2.SetActive(false);
                 ItemInHand.SetActive(true);
                 sr.flipX = false;
                anim.SetBool("Walk", true);
                
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Movespeed = 6;
            }
            else
            {
                Movespeed = 4;
            }
        Vector2 pos = new Vector2(playerfeet.transform.position.x, playerfeet.transform.position.y);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);

        if(hit.collider != null && hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Water_Texture"){
            _rigid.drag = 40;
            CanJump = false;
            CanSwim = true;
            Debug.Log("en");
        } else {
            CanSwim = false;
            _rigid.drag = 0;
        }



    }
}
