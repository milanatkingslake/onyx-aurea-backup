//<script language="javascript">  'This tag is to fake Interdev into recognizing this file as a javascript file 

	var moXmlDom = new ActiveXObject("Msxml2.DOMDocument")
	var moXslDom = new ActiveXObject("Msxml2.DOMDocument")
		
	moXmlDom.async = false
	moXslDom.async = false
	loadXmlDocumentFile(moXslDom,'lm_target.xsl')
	function jsResize(){
		var e
		try{
			document.all.iddiv_resultlist.children(1).style.height = window.document.body.offsetHeight - document.all.iddiv_resultlist.children(0).offsetHeight - document.all.iddiv_toolbar.offsetHeight
			document.all.iddiv_resultlist.children(1).style.width = window.document.body.offsetWidth - 1	
		}catch(e){}
	}
	
/*ONYX EMAIL ACCELERATOR CUSTOMIZATION*/    
    function jsDoMassEmailBulkAction() {
        var sClientLocation = 'http://internalwebserver/OnyxEmailAccelerator/client.asp';
        var xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
        var sResponseCode;
        var sStatusCode;
        var sStatusText;
        var sqltext;
        var sSQLXML;
        
        if (!jsIsAllSelected()) {
           jsMessageBox("The Onyx Email Accelerator is designed to send to all users designated in the List Management Query. Please select the 'All' checkbox or refine your List Management query to include only those users in which you wish to send mail.", 0, 4, '')
            return false;
        }
        
        window.parent.frameLM.children("lm_main").contentWindow.vbGenerateSQL();
        sqltext = (window.parent.frameLM.children("lm_main").contentWindow.txtSQL.value);
        
        sSQLXML = "<query><![CDATA[" + sqltext + "]]></query>";
        xmlHttp.open("POST", "BulkAction_MassEmailQueue.asp", false);
        xmlHttp.send(sSQLXML);
        
        sStatusCode = xmlHttp.status;
        sStatusText = xmlHttp.statusText;
        
       /* alert (xmlHttp.responseText);
        return false;*/
     
        if (sStatusCode == 200) {
            sResponseCode = xmlHttp.responseText;
            switch(sResponseCode){
				case "-1":
					alert("There was a problem retrieving the next ID");
					break;
                case "-2":
                    alert("There was a problem retrieving the List Management Query");
                    break;
                case "-3":
                    alert("There was an error while executing BulkAction_MassEmailQueue.asp");
                    break;
                default:
                    window.open(sClientLocation + '?gMailBatchID=' + sResponseCode, 'EmailAccelerator','resizable=yes,width=745,height=600,scrollbars=yes,menubar=no,location=no,status=yes');

                }
        }else {
            var x = window.open('bulkAction_MassEmailError.htm','Debug');
            x.document.write(xmlHttp.responseText);
            x.document.close();
            
        }
       
        xmlHttp.close;

    }
/*ONYX EMAIL ACCELERATOR CUSTOMIZATION*/  

	function jsBulkActionDo(){
		var e;
		var bAllSelected;

		if (!mbTableBuilt){
			return 1;
		}
		
		bAllSelected = jsIsAllSelected();
		if (bAllSelected) {
			if (mbExceedMaxRow){
				if (!jsMessageBox(res_BulkActionForAllQueryResult,4,2, '')){
					return 1;
				}
			}
			jsDoBulkActionForAll();
			
			return 1;
		}
/*		
		if (bAllSelected){
			if(document.all.idselect_bulkinserttype.value=='exportExcel' || document.all.idselect_bulkinserttype.value=='exportCSV')
			{
				jsDoBulkActionForAll();			
				return 1;
			}
		}
*/		
		
			switch(document.all.idselect_bulkinserttype.value){
				case 'exportExcelClientSide':
					vbExportExcelClientSide();
					break;
				case 'exportExcel':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('exportExcel', jsTargetXML());
					break;
				case 'exportCSV':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('exportCSV', jsTargetXML());
					break;
				case 'incidentSales':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('incidentSales', jsTargetXML());
					break;
				case 'incidentService':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('incidentService', jsTargetXML());
					break;
				case 'incidentSupport':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('incidentSupport', jsTargetXML());
					break;
				case 'externalContact':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('externalContact', jsTargetXML());
					break;
				case 'internalContact':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('internalContact', jsTargetXML());
					break;
				case 'campaign':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('campaign', jsTargetXML());
					break;
				case 'literature':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('literature', jsTargetXML());
					break;							
				case 'surveys':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('surveys', jsTargetXML());
					break;							
				case 'script':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('script', jsTargetXML());
					break;
				case 'territoryReassignment':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('territoryReassignment', jsTargetXML());
					break;											
				case 'quickSubscribe':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('quickSubscribe', jsTargetXML());
					break;							
				case 'quickUnsubscribe':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('quickUnsubscribe', jsTargetXML());
					break;							
				case 'advancedSubscription':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('advancedSubscription', jsTargetXML());
					break;							
                /*ONYX EMAIL ACCELERATOR CUSTOMIZATION*/   
                case 'emailAccelerator':
                    jsDoMassEmailBulkAction();
                    break;		
                /*ONYX EMAIL ACCELERATOR CUSTOMIZATION*/  
				default:
					jsMessageBox(res_NoSelectedAction, 0, 4, '');
					break;
			}
	}	
	function jsTargetXML(){
		moXmlDom.loadXML(vbSelectedRows(msTableName))
		// fill the view id into the XSL so that it appears in the output XML
		moXslDom.selectSingleNode('//xsl:variable[@name=\'viewId\']').text = msViewId
		moXslDom.selectSingleNode('//xsl:variable[@name=\'targetColumnOrdinal\']').text = msBulkActionColumnOrdinal
		return(moXmlDom.transformNode(moXslDom))
	}
	
	
	function jsDoBulkActionForAll(){
		var e;
		
		try {
			switch(document.all.idselect_bulkinserttype.value){
				case 'exportExcelClientSide':
					jsMessageBox(res_NotSupportClientSideExport, 0, 4, '');		
					break;
				case 'exportExcel':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('exportExcel', jsTargetXMLAll());
					break;
				case 'exportCSV':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('exportCSV', jsTargetXMLAll());
					break;
				case 'incidentSales':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('incidentSales', jsTargetXMLAll());
					break;
				case 'incidentService':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('incidentService', jsTargetXMLAll());
					break;
				case 'incidentSupport':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('incidentSupport', jsTargetXMLAll());
					break;
				case 'externalContact':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('externalContact', jsTargetXMLAll());
					break;
				case 'internalContact':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('internalContact', jsTargetXMLAll());
					break;
				case 'campaign':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('campaign', jsTargetXMLAll());
					break;
				case 'literature':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('literature', jsTargetXMLAll());
					break;							
				case 'surveys':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('surveys', jsTargetXMLAll());
					break;
				case 'script':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('script', jsTargetXMLAll());
					break;
				case 'territoryReassignment':
					window.parent.frameLM.children("lm_main").contentWindow.vbDoBulkAction('territoryReassignment', jsTargetXMLAll());
					break;				
                /*ONYX EMAIL ACCELERATOR CUSTOMIZATION*/   
                case 'emailAccelerator':
                    jsDoMassEmailBulkAction();
                    break;	
                /*ONYX EMAIL ACCELERATOR CUSTOMIZATION*/   
				default:
					jsMessageBox(res_NoSelectedAction, 0, 4, '');
					break;
			}
		} catch(e) {}
	
	}
	
	function jsTargetXMLAll(){
	
		var sXML = '<targets viewId="' + msViewId + '"><allResults/></targets>'					
		return(sXML)		

	}
	
	function jsIsAllSelected(){
	
		var sTableHeaderName = 'idtable_' + msTableName + 'header';
		var oTableHeader = document.all.item(sTableHeaderName);
		var e;
	
		try{			
			for(var iRow = 0; iRow < oTableHeader.rows.length; iRow++){ 
				var oInputNodes = oTableHeader.rows(iRow).cells(0).getElementsByTagName("INPUT");
				if(oInputNodes.length > 0){
					if (oInputNodes.item(0).checked){
						return true;
					}
				}	
			}
		}
		catch(e){}	
		
		return false;
	}
	
	function jsUnload(){
		try{
			moExpContControl.destroy();
		}catch(e){}
	}
