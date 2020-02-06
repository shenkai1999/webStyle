/**
 * SoapWebServiceImplService.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package client;

public interface SoapWebServiceImplService extends javax.xml.rpc.Service {
    public java.lang.String getSoapWebServiceImplAddress();

    public client.SoapWebServiceImpl_PortType getSoapWebServiceImpl() throws javax.xml.rpc.ServiceException;

    public client.SoapWebServiceImpl_PortType getSoapWebServiceImpl(java.net.URL portAddress) throws javax.xml.rpc.ServiceException;
}
