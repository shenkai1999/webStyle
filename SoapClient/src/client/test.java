package client;

import javax.management.remote.rmi.RMIConnection;

public class test {
  public static void main(String[] argv) {
      try {
          SoapWebServiceImplServiceLocator locator = new SoapWebServiceImplServiceLocator();
          SoapWebServiceImpl_PortType service = locator.getSoapWebServiceImpl();
          System.out.println(service.IDcardCheck("1223"));
      } catch (javax.xml.rpc.ServiceException ex) {
          ex.printStackTrace();
      } catch (java.rmi.RemoteException ex) {
          ex.printStackTrace();
      }
  }
}
