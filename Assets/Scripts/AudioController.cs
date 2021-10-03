using UnityEngine;

public class AudioController : MonoBehaviour {
    public AudioSource AudioSourceMusicaDeFundo, AudioSourceSFX;
    public AudioClip[] musicasDeFundo;

    private void Start() {
        int indexDaMusicaDeFundo = Random.Range(0, musicasDeFundo.Length);

        AudioClip musicaDeFundoDessaFase = musicasDeFundo[indexDaMusicaDeFundo];
        AudioSourceMusicaDeFundo.clip = musicaDeFundoDessaFase;
        AudioSourceMusicaDeFundo.Play();
    }

    public void ToqueSFX(AudioClip clip) {
        AudioSourceSFX.PlayOneShot(clip);
    }
}