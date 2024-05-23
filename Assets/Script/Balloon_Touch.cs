using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_Touch : MonoBehaviour
{
    #region
    /* public bool isTouched = false; // Balonun tutulup tutulmad���n� kontrol etmek i�in kullan�l�r
      private Vector3 touchPosition; // Balonun tutuldu�u konumu saklar

      public float launchForce = 10f; // Balonun f�rlatma g�c�
      public float releaseThreshold = 0.1f; // Balonun b�rak�ld��� kabul edilebilecek e�ik de�eri

      private Rigidbody rb;

      void Start()
      {
          rb = GetComponent<Rigidbody>();
      }

      void Update()
      {
          // Fare t�klamas�n� veya dokunmay� alg�lar
          if (Input.GetMouseButtonDown(0))
          {
              // Balonu tutma i�lemi
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
              // Balonu b�rakma i�lemi
              Vector3 releasePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

              float swipeDistance = releasePosition.y - touchPosition.y;

              if (swipeDistance > releaseThreshold)
              {
                  // Yukar� do�ru hareket etme i�lemi
                  Vector3 launchDirection = new Vector3(0f, swipeDistance, 0f).normalized;
                  rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
              }

              isTouched = false;
          }
      }*/
    /*  public float balloonSpeed = 5f; // Balonun hareket h�z�
      Vector2 touchStartPosition;
      private Rigidbody rb;

      private void Awake()
      {
          rb = GetComponent<Rigidbody>();
      }

      private void Update()
      {
          // Kullan�c�n�n dokunmalar�n� kontrol etmek i�in dokunmatik veya fare giri�ini kullanabilirsiniz.
          // A�a��da dokunmatik giri�i i�in bir �rnek verilmi�tir.
          if (Input.touchCount > 0)
          {
              Touch touch = Input.GetTouch(0);

              if (touch.phase == TouchPhase.Began)
              {
                  // Dokunman�n ba�lad��� noktay� kaydedin
                   touchStartPosition = touch.position;
              }
              else if (touch.phase == TouchPhase.Ended)
              {
                  // Dokunman�n bitti�i noktay� kaydedin
                  Vector2 touchEndPosition = touch.position;

                  // Dokunman�n y�n�n� hesaplay�n
                  Vector2 touchDirection = touchEndPosition - touchStartPosition;

                  // Balonun x ve y eksenlerinde hareket etmesini sa�lay�n
                  Vector3 movement = new Vector3(touchDirection.x, touchDirection.y, 0f);
                  movement.Normalize(); // Hareket vekt�r�n� normalize edin

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

             // Z ekseninde hareket etmeyece�imiz i�in z eksenini s�f�rl�yoruz
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

            // Z ekseninde hareket etmeyece�imiz i�in z eksenini s�f�rl�yoruz
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
