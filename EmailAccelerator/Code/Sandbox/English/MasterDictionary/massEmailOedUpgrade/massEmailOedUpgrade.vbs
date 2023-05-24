' VBScript File
'Upgrading an OED for Email Accelerator creates the following entries:
'1)	Create the massEmailBatch object and methods
'2)	Create the procedures needed to implement the massEmailBatch functionality
'3)	Map the massEmailBatch methods to the stored procedures


Function massEmailOedUpgrade(sOEDLocation)

	Dim oOEDXml 'As DOMDocument
	Dim oNewXml 'As DOMDocument
	Dim oNewNode 'As IXMLDOMNode
   Dim oOedNodeForModification 'As IXMLDOMNode
	Dim oFileSystem 'As FileSystemObject
	Dim sMethodStatus 'As String
      
	sMethodStatus = "Success"
      
	'Default empty parameters
	If (sOEDLocation = "") Then
	    sOEDLocation = "C:\Program Files\Onyx\AppServer\Applications\Onyx"
	End If
    
   ' Add a slash to the path in case we haven't been provided with one      
	If Right(sOedLocation, 1) <> "\" Then
		sOedLocation = sOedLocation & "\"
	End If

	  
   ' We will use the working copy for the modifications - the user will 
   ' need to publish the OED before the changes are applied to the system.  
	Set oFileSystem = CreateObject("Scripting.FileSystemObject")
   Set oOedXml = CreateObject("MSXML2.FreeThreadedDOMDocument")
	oOedXml.load (sOedLocation & "OnyxEnterpriseDictionaryWC.xml")

           
   If oOedXml.parseError.errorCode <> 0 Then
       ' The OED could not be opened - return an error.
       sMethodStatus = "Failure: The working copy of the OED, " & sOedLocation & "OnyxEnterpriseDictionaryWC.xml" & ", could not be opened."
   Else
      
		' We have an OED ready to upgrade: Save a backup copy (may overwright existing backup)
		oOedXml.Save (sOedLocation & "OnyxEnterpriseDictionaryWC_bak.xml")
	
		Set oNewXml = CreateObject("MSXML2.FreeThreadedDOMDocument")
	
             
                                                      
		' **Create the massEmailBatch object and methods**
		Set oOedNodeForModification = oOedXml.documentElement.selectSingleNode("//dictionary/logicalModel/businessObjects")
      
		oNewXml.load ("logicalModel.xml")
		Set oNewNode = oNewXml.documentElement.selectSingleNode("//businessObject")
		oOedNodeForModification.appendChild(oNewNode)

                                                                              
                      
		' **Create the procedures needed to implement the massEmailBatch functionality**
		Set oOedNodeForModification = oOedXml.documentElement.selectSingleNode("//dictionary/physicalModel/procedures")
		
      oNewXml.load ("physicalModelSDpcdEmailBatchInsert.xml")
		Set oNewNode = oNewXml.documentElement.selectSingleNode("//procedure")
		oOedNodeForModification.appendChild(oNewNode)

      oNewXml.load ("physicalModelSDpcdEmailBatchExecute.xml")
		Set oNewNode = oNewXml.documentElement.selectSingleNode("//procedure")
		oOedNodeForModification.appendChild(oNewNode)

                        
                      
		' **Map the massEmailBatch methods to the stored procedures**
		Set oOedNodeForModification = oOedXml.documentElement.selectSingleNode("//dictionary/logicalPhysicalMap/procedureMaps")
		
      oNewXml.load ("logicalPhysicalMapSDpcdEmailBatchInsert.xml")
		Set oNewNode = oNewXml.documentElement.selectSingleNode("//procedureMap")
		oOedNodeForModification.appendChild(oNewNode)

      oNewXml.load ("logicalPhysicalMapSDpcdEmailBatchExecute.xml")
		Set oNewNode = oNewXml.documentElement.selectSingleNode("//procedureMap")
		oOedNodeForModification.appendChild(oNewNode)

                      
		' Save the modified OED
		oOedXml.Save (sOedLocation & "OnyxEnterpriseDictionaryWC.xml")
	
        
	End If
      
	
   massEmailOedUpgrade = sMethodStatus
      
      					
	'Destroy objects
	Set oOEDXml = Nothing
	Set oNewXml = Nothing
	Set oNewNode = Nothing
   Set oOedNodeForModification = Nothing
	Set oFileSystem = Nothing
	Set sMethodStatus = Nothing
				  
End Function