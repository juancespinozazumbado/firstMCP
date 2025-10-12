namespace Server.utils;

using system;

public static class StringFormat 
{

   private static final String FormatterId = Guid.NewGuid();
    
    

    public static void FormatStringConfig(string config){
        if(config is null or empty){
            throw new Exception("string must not be an empty string");
        }

    }


}