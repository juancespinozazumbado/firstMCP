namespace Server.utils;

using system;

public static class StringFormat 
{

    private static readonly ILoger<StringFormat> _logger;
    private static readonly int LimitTraceHold = 500; 
    private static readonly String FormatterId = Guid.NewGuid();
    
    

    public static void FormatStringConfig(string config){
        if(config is null or empty){
            throw new Exception("string must not be an empty string");
        }

    }


    public static void AssignConfigFiles(object configOptions, File file = null){

        if(file is null){
            throw new Exception("File can't be null");
        }
    }

}