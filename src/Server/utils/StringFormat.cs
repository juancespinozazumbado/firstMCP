namespace Server.utils;

public static class StringFormat 
{

    public static void FormatStringConfig(string config);

    public static void AssignConfigFiles(object configOptions, File file = null){

        if(file is null){
            throw new Exception("File can't be null");
        }
    }

}