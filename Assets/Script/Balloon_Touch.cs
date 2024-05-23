using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_Touch : MonoBehaviour
{
    #region
    /* public bool isTouched = false; // Balonun tutulup tutulmadýðýný kontrol etmek için kullanýlýr
      private Vector3 touchPosition; // Balonun tutulduðu konumu saklar

      public float launchForce = 10f; // Balonun fýrlatma gücü
      public float releaseThreshold = 0.1f; // Balonun býrakýldýðý kabul edilebilecek eþik deðeri

      private Rigidbody rb;

      void Start()
      {
          rb = GetComponent<Rigidbody>();
      }

      void Update()
      {
          // Fare týklamasýný veya dokunmayý algýlar
          if (Input.GetMouseButtonDown(0))
          {
              // Balonu tutma iþlemi
              RaycastHit hit;
              Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

              if (Physics.Raycast(ray, out hit))
              {
                  if (hit.collider.gameObject == gameObject)
                  {
                      isTouched = true;
                      touchPosition = hit.point;
                  }
              }
          }
          else if (Input.GetMouseButtonUp(0) && isTouched)
          {
              // Balonu býrakma iþlemi
              Vector3 releasePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

              float swipeDistance = releasePosition.y - touchPosition.y;

              if (swipeDistance > releaseThreshold)
              {
                  // Yukarý doðru hareket etme iþlemi
                  Vector3 launchDirection = new Vector3(0f, swipeDistance, 0f).normalized;
                  rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
              }

              isTouched = false;
          }
      }*/
    /*  public float balloonSpeed = 5f; // Balonun hareket hýzý
      Vector2 touchStartPosition;
      private Rigidbody rb;

      private void Awake()
      {
          rb = GetComponent<Rigidbody>();
      }

      private void Update()
      {
          // Kullanýcýnýn dokunmalarýný kontrol etmek için dokunmatik veya fare giriþini kullanabilirsiniz.
          // Aþaðýda dokunmatik giriþi için bir örnek verilmiþtir.
          if (Input.touchCount > 0)
          {
              Touch touch = Input.GetTouch(0);

              if (touch.phase == TouchPhase.Began)
              {
                  // Dokunmanýn baþladýðý noktayý kaydedin
                   touchStartPosition = touch.position;
              }
              else if (touch.phase == TouchPhase.Ended)
              {
                  // Dokunmanýn bittiði noktayý kaydedin
                  Vector2 touchEndPosition = touch.position;

                  // Dokunmanýn yönünü hesaplayýn
                  Vector2 touchDirection = touchEndPosition - touchStartPosition;

                  // Balonun x ve y eksenlerinde hareket etmesini saðlayýn
                  Vector3 movement = new Vector3(touchDirection.x, touchDirection.y, 0f);
                  movement.Normalize(); // Hareket vektörünü normalize edin

                  // Balonu hareket ettirin
                  rb.velocity = movement * balloonSpeed;
              }
          }
      }*/
    /* private Vector3 touchStartPosition;
     private Rigidbody rb;

     public float speed = 5f;

     private void Start()
     {
         rb = GetComponent<Rigidbody>();
     }

     private void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             touchStartPosition = Input.mousePosition;
         }

         if (Input.GetMouseButtonUp(0))
         {
             Vector3 touchEndPosition = Input.mousePosition;
             Vector3 swipeDirection = (touchEndPosition - touchStartPosition).normalized;

             // Z ekseninde hareket etmeyeceðimiz için z eksenini sýfýrlýyoruz
             swipeDirection.z = 0f;

             rb.velocity = swipeDirection * speed;
         }
     }*/
    #endregion
    
    private float touchTime = 0f;
    private bool isPopped = false;
    private bool isTouched = false;
    private Vector3 touchStartPosition;
    private Rigidbody rb;
   // public  bool _isDrrag = false;
    public float speed = 5f; 
    private float m_touchTime = 1.5f;
    [SerializeField] private GameManager _gm;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnMouseDown()
    {
        touchStartPosition = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(touchStartPosition);
        RaycastHit hit;
        Balloon_Gravity._gravity = false;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == gameObject)
            {
                isTouched = true;
            }
        }
        touchTime = Time.time;
    }
    private void OnMouseDrag()
    {
        if (!isPopped && Time.time - touchTime >= m_touchTime)
        {
            isTouched = false;
            Balloon_Gravity._gravity = true;

            touchTime = 0f;
            //_isDrrag = true;
            // _gm.TheBalloonPopped();
        }
    }
    private void OnMouseUp()
    {
        isTouched = false;
        Balloon_Gravity._gravity = true;

        touchTime = 0f;
    }
    private void Update()
    {

        if (isTouched)
        {
            Vector3 touchCurrentPosition = Input.mousePosition;
            Vector3 swipeDirection = (touchCurrentPosition - touchStartPosition).normalized;

            // Z ekseninde hareket etmeyeceðimiz için z eksenini sýfýrlýyoruz
            swipeDirection.z = 0f;

            rb.velocity = swipeDirection * speed;
        }
    }
    // void PopBalloon()
    // {
    //     if (_isDrrag)
    //     {
    //         isPopped = true;
    //         // Balloon popping logic
    //     }
    //
    // }
}
