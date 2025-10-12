namespace Server.utils;

public static class StringFormat 
{

    public static void FormatStringConfig(string config){
        if(config is null or empty){
            throw new Exception("string must not be an empty string");
        }

    }


}