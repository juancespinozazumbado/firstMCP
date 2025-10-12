namespace Server.utils;

public static class StringFormat 
{

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