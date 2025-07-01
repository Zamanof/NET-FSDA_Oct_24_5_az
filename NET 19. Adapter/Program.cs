// Adapter pattern

List<IAudioFile> musicPlayList = new List<IAudioFile>();
musicPlayList.Add(new Mp3());
musicPlayList.Add(new Wav());
musicPlayList.Add(new Mp3());
musicPlayList.Add(new FLAC());
musicPlayList.Add(new OggAudioFileAdapter());

musicPlayList.ForEach(m => m.Play());

interface IAudioFile
{
    void Play();
}

class Mp3 : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("Mp3 is playing!!!");
    }
}

class Wav : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("Wav is playing!!!");
    }
}

class FLAC : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("FLAC is playing!!!");
    }
}

// Object Adapter
//class OggAudioFileAdapter : IAudioFile
//{
//    private Ogg m_ogg = new();
//    public void Play()
//    {
//        // some converting operations
//        m_ogg.PlaySomething(true);
//    }
//}

// Object Adapter
class OggAudioFileAdapter : Ogg, IAudioFile
{

    public void Play()
    {
        // some converting operations
        this.PlaySomething(true);
    }
}

