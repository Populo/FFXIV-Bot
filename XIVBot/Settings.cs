using System.IO;
using Newtonsoft.Json;

namespace XIVBot;

public class Config
{
    public char LeftTurn { get; set; }
    public char RightTurn { get; set; }
    public char Forward { get; set; }
    public char Backward { get; set; }
    public char MoveLeft { get; set; }
    public char MoveRight { get; set; }
    public char Jump { get; set; }
    public char Craft { get; set; }
    public char Gather { get; set; }

    public static Config BuildDefault()
    {
        return new Config
        {
            LeftTurn = 'A',
            Backward = 'S',
            MoveRight = 'E',
            RightTurn = 'D',
            Craft = ']',
            Forward = 'W',
            MoveLeft = 'Q',
            Gather = '[',
            Jump = ' '
        };
    }

    public static Config LoadConfig()
    {
        Config config;
        if (File.Exists(Helper.ConfigFile))
        {
            try
            {
                return JsonConvert.DeserializeObject<Config>(File.ReadAllText(Helper.ConfigFile)) 
                         ?? throw new Exception("Cannot read config file");
            }
            catch
            {
                config = BuildDefault();
            }
        }
        else
        {
            // config file does not exist
            config = BuildDefault();
        }
        // valid config returned already
        WriteConfigFile(config);

        return config;
    }

    public static void WriteConfigFile(Config config)
    {
        string contents = JsonConvert.SerializeObject(config);
        Directory.CreateDirectory(Helper.ConfigPath);
        File.WriteAllText(Helper.ConfigFile, contents);
    }
}

