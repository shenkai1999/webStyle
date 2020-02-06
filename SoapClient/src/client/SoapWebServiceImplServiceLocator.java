/**
 * SoapWebServiceImplServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package client;

public class SoapWebServiceImplServiceLocator extends org.apache.axis.client.Service implements client.SoapWebServiceImplService {

    public SoapWebServiceImplServiceLocator() {
    }


    public SoapWebServiceImplServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public SoapWebServiceImplServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for SoapWebServiceImpl
    private java.lang.String SoapWebServiceImpl_address = "http://localhost:8080/services/SoapWebServiceImpl";

    public java.lang.String getSoapWebServiceImplAddress() {
        return SoapWebServiceImpl_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String SoapWebServiceImplWSDDServiceName = "SoapWebServiceImpl";

    public java.lang.String getSoapWebServiceImplWSDDServiceName() {
        return SoapWebServiceImplWSDDServiceName;
    }

    public void setSoapWebServiceImplWSDDServiceName(java.lang.String name) {
        SoapWebServiceImplWSDDServiceName = name;
    }

    public client.SoapWebServiceImpl_PortType getSoapWebServiceImpl() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(SoapWebServiceImpl_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getSoapWebServiceImpl(endpoint);
    }

    public client.SoapWebServiceImpl_PortType getSoapWebServiceImpl(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            client.SoapWebServiceImplSoapBindingStub _stub = new client.SoapWebServiceImplSoapBindingStub(portAddress, this);
            _stub.setPortName(getSoapWebServiceImplWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setSoapWebServiceImplEndpointAddress(java.lang.String address) {
        SoapWebServiceImpl_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (client.SoapWebServiceImpl_PortType.class.isAssignableFrom(serviceEndpointInterface)) {
                client.SoapWebServiceImplSoapBindingStub _stub = new client.SoapWebServiceImplSoapBindingStub(new java.net.URL(SoapWebServiceImpl_address), this);
                _stub.setPortName(getSoapWebServiceImplWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("SoapWebServiceImpl".equals(inputPortName)) {
            return getSoapWebServiceImpl();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://server", "SoapWebServiceImplService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://server", "SoapWebServiceImpl"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("SoapWebServiceImpl".equals(portName)) {
            setSoapWebServiceImplEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
