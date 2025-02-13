using UnityEngine;

public class Hitter : MonoBehaviour
{
 public ParticleSystem particles;

 public void OnClick()
 {
    particles.Play();
 }
}
