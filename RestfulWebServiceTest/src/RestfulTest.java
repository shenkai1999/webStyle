import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;

public class RestfulTest {
    public void getMethod(String url)throws IOException{
        URL restURL = new URL(url);
        HttpURLConnection conn = (HttpURLConnection) restURL.openConnection();
        conn.setRequestMethod("PUT");
        conn.setRequestProperty("Accept","application/json");
        BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        String line;
        while((line = br.readLine())!=null){
            System.out.println(line);
        }
        br.close();

    }
    public static void main(String [] args){
        RestfulTest restUtil = new RestfulTest();
        try{
            String a=URLEncoder.encode("你好沈楷", "UTF-8");
            restUtil.getMethod("http://127.0.0.1:8080/changetopinyin?hanzi="+a);
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
    }
}
