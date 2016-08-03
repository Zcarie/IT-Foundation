// File: tv.cs

class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;
    private string input = "tv1";

    public bool IsOn 
    {
        get
        {
            return isOn;
        }
set
        {
            isOn = value;
        }
    }
    public int Channel 
    {
        get
        {
            return channel;
        }
set
        {
            channel = value;
        }
    }
    public int Volume 
    {
        get
        {
            return volume;
        }
set
        {
            volume = value;
        }
    }
    public string Input
    {
        get
        {
            return input;
        }
        set
        {
            input = value;
        }
    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (!tv.IsOn)
        {
            tv.IsOn = true;
        }

        tv.Channel = 3;
        
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.Input = "HDMI1";

        tv.IsOn = false;
    }
}