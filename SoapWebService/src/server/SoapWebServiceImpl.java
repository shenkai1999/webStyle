package server;
import java.util.regex.*;
public class SoapWebServiceImpl implements SoapWebService {
  public String IDcardCheck(String IDNum){
    Pattern idNumPattern = Pattern.compile("(^[1-9]\\d{5}(18|19|([23]\\d))\\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\\d{3}[0-9Xx]$)|(^[1-9]\\d{5}\\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\\d{2}$)");
    Matcher idNumMatcher = idNumPattern.matcher(IDNum);
      System.out.println(IDNum);
    if (idNumMatcher.matches()){
      return "true";
    }
    else {
      return "false";
    }
  }

}
