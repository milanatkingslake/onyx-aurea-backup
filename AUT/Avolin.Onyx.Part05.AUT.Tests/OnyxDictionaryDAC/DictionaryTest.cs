using System;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using MSXML2;
using NUnit.Framework;
using OnyxDictionaryDAC;
using Shouldly;

namespace Avolin.Onyx.Part05.AUT.Tests.OnyxDictionaryDAC
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.Dictionary" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DictionaryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Dictionary" />)
        /// </summary>
        public DictionaryTest() : base(typeof(Dictionary))
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Dictionary) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dictionaryInstanceType;
        private Dictionary _dictionaryInstance;
        private Dictionary _dictionaryInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Dictionary" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dictionaryInstanceType = typeof(Dictionary);
            _dictionaryInstanceFixture = this.Create<Dictionary>(false);
            _dictionaryInstance = _dictionaryInstanceFixture ?? this.Create<Dictionary>(true);
            CurrentInstance = _dictionaryInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Dictionary) Initializer

        #region Methods

        private const string MethodPrintLog = "PrintLog";
        private const string MethodExecute = "Execute";
        private const string MethodExecuteWithHelpers = "ExecuteWithHelpers";
        private const string MethodLogException = "LogException";
        private const string MethodAddSimpleError = "AddSimpleError";
        private const string MethodEncodeParamsArray = "EncodeParamsArray";
        private const string MethodEncodeParams = "EncodeParams";
        private const string MethodGetNewID = "GetNewID";
        private const string MethodretrieveGuids = "retrieveGuids";
        private const string MethodGetNewObjectTypeEnum = "GetNewObjectTypeEnum";
        private const string MethodFileExists = "FileExists";
        private const string MethodGetDictionaryFilePath = "GetDictionaryFilePath";
        private const string MethodGetDictionarySchemaPath = "GetDictionarySchemaPath";
        private const string MethodGetMethodList = "GetMethodList";
        private const string MethodGetMethodListFromObject = "GetMethodListFromObject";
        private const string MethodClearCollection = "ClearCollection";
        private const string MethodBuildDeletedMethodsParameter = "BuildDeletedMethodsParameter";
        private const string MethodLoadDictionaryFromFile = "LoadDictionaryFromFile";
        private const string MethodSaveDictionaryToFile = "SaveDictionaryToFile";
        private const string MethodFindObjectByName = "FindObjectByName";
        private const string MethodFindObjectByID = "FindObjectByID";
        private const string MethodAddSectionsByID = "AddSectionsByID";
        private const string MethodValidateXMLSection = "ValidateXMLSection";
        private const string MethodValidateXML = "ValidateXML";
        private const string MethodStoreObjectXMLInDictionary = "StoreObjectXMLInDictionary";
        private const string MethodStoreBusinessObjectXMLInDictionary = "StoreBusinessObjectXMLInDictionary";
        private const string MethodDeleteObjectXMLInDictionary = "DeleteObjectXMLInDictionary";
        private const string MethodDeleteBusinessObjectXMLInDictionary = "DeleteBusinessObjectXMLInDictionary";
        private const string MethodDeleteRelationships = "DeleteRelationships";
        private const string MethodCheckUpdateDeletions = "CheckUpdateDeletions";
        private const string MethodDeleteObjectPhysicalMaps = "DeleteObjectPhysicalMaps";
        private const string MethodDeleteProcedureMaps = "DeleteProcedureMaps";
        private const string MethodDeleteAllObjectsInDictionary = "DeleteAllObjectsInDictionary";
        private const string MethodCheckNextObjectTypeNum = "CheckNextObjectTypeNum";
        private const string MethodCheckDBEngine = "CheckDBEngine";
        private const string MethodCheckObjectPropertyBoolean = "CheckObjectPropertyBoolean";
        private const string MethodCheckObjectID = "CheckObjectID";
        private const string MethodCheckObjectTypeEnum = "CheckObjectTypeEnum";
        private const string MethodCheckObjectProperty = "CheckObjectProperty";
        private const string MethodStringInList = "StringInList";
        private const string MethodCheckObjectPropertyEnum = "CheckObjectPropertyEnum";
        private const string MethodCheckNameCharsAndUniqueness = "CheckNameCharsAndUniqueness";
        private const string MethodCheckNameUniqueness = "CheckNameUniqueness";
        private const string MethodCheckNameChars = "CheckNameChars";
        private const string MethodValidateObject = "ValidateObject";
        private const string MethodNameInCollection = "NameInCollection";
        private const string MethodNameInObjectCollection = "NameInObjectCollection";
        private const string MethodAddObjectToObjectCollection = "AddObjectToObjectCollection";
        private const string MethodDeleteObjectInObjectCollection = "DeleteObjectInObjectCollection";
        private const string MethodGetObjectInfoFromCollection = "GetObjectInfoFromCollection";
        private const string MethodValidateObjectReferences = "ValidateObjectReferences";
        private const string MethodGetRelationshipObjectName = "GetRelationshipObjectName";
        private const string MethodValidateRelationshipReferences = "ValidateRelationshipReferences";
        private const string MethodGetObjectPhysicalMapName = "GetObjectPhysicalMapName";
        private const string MethodValidateObjectPhysicalReferences = "ValidateObjectPhysicalReferences";
        private const string MethodGetProcedureMapsNames = "GetProcedureMapsNames";
        private const string MethodValidateProcedureMapReferences = "ValidateProcedureMapReferences";
        private const string MethodMethodCallNotCircular = "MethodCallNotCircular";
        private const string MethodMethodCallNotCircularRecurse = "MethodCallNotCircularRecurse";
        private const string MethodDownstreamObjectReferenceValid = "DownstreamObjectReferenceValid";
        private const string MethodDownstreamObjectReferenceRecurse = "DownstreamObjectReferenceRecurse";
        private const string MethodValidateAllObjects = "ValidateAllObjects";
        private const string MethodValidateRelationships = "ValidateRelationships";
        private const string MethodValidateObjectPhysicalMaps = "ValidateObjectPhysicalMaps";
        private const string MethodValidateProcedureMaps = "ValidateProcedureMaps";
        private const string MethodValidatePhysicalTables = "ValidatePhysicalTables";
        private const string MethodValidatePhysicalProcedures = "ValidatePhysicalProcedures";
        private const string MethodDoPostChangeProcessing = "DoPostChangeProcessing";
        private const string MethodValidateAllObjectReferences = "ValidateAllObjectReferences";
        private const string MethodUpdateValidFlags = "UpdateValidFlags";
        private const string MethodMakeRefreshList = "MakeRefreshList";
        private const string MethodCreateEnumsCollection = "CreateEnumsCollection";
        private const string MethodStringsEqualWithNull = "StringsEqualWithNull";
        private const string MethodSetReturnProperties = "SetReturnProperties";
        private const string MethodAddSectionsToBO = "AddSectionsToBO";
        private const string MethodDoSave = "DoSave";
        private const string MethodDoDelete = "DoDelete";
        private const string MethodDoSaveCollection = "DoSaveCollection";
        private const string MethodDoRetrieve = "DoRetrieve";
        private const string MethodDoRetrieveCollection = "DoRetrieveCollection";
        private const string MethodDoDeleteAll = "DoDeleteAll";
        private const string MethodDoValidateCollection = "DoValidateCollection";
        private const string MethodSetValidationStatus = "SetValidationStatus";
        private const string MethodGetValidationStatus = "GetValidationStatus";
        private const string MethodDoValidateStore = "DoValidateStore";
        private const string MethodDoPublishToDatabase = "DoPublishToDatabase";
        private const string MethodCleanUpDanglingPropertiesProcedureMap = "CleanUpDanglingPropertiesProcedureMap";
        private const string MethodCallAOEDCreation = "CallAOEDCreation";
        private const string MethodCallSQLGenCreation = "CallSQLGenCreation";
        private const string MethodDoRetrieveEnums = "DoRetrieveEnums";
        private const string MethodobjectEqualsNull = "objectEqualsNull";
        private const string MethodBooleansEqualWithNull = "BooleansEqualWithNull";

        #endregion

        #region Fields

        private const string FieldDICTIONARYDAC_LOGID = "DICTIONARYDAC_LOGID";
        private const string FieldDICTIONARYDAC_PROGID = "DICTIONARYDAC_PROGID";
        private const string FieldDICTIONARYDAC_PROGID_COLON = "DICTIONARYDAC_PROGID_COLON";
        private const string FieldDICTIONARYDAC_LOCDLL = "DICTIONARYDAC_LOCDLL";
        private const string FieldCONFIGKEY_SUBKEY = "CONFIGKEY_SUBKEY";
        private const string FieldCONFIGKEY_DICTIONARYPATH = "CONFIGKEY_DICTIONARYPATH";
        private const string FieldCONFIGKEY_DICTIONARYWORKINGCOPYPATH = "CONFIGKEY_DICTIONARYWORKINGCOPYPATH";
        private const string FieldCONFIGKEY_DICTIONARYSCHEMAPATH = "CONFIGKEY_DICTIONARYSCHEMAPATH";
        private const string FieldCUSTOM_ERR_SOURCE = "CUSTOM_ERR_SOURCE";
        private const string FieldCUSTOM_VBOBJECTERROR = "CUSTOM_VBOBJECTERROR";
        private const string FieldCUSTOM_ERR_ERRNUMBASE = "CUSTOM_ERR_ERRNUMBASE";
        private const string FieldCUSTOM_ERR_BADDOCUMENT = "CUSTOM_ERR_BADDOCUMENT";
        private const string FieldCUSTOM_ERRDESC_BADDOCUMENT = "CUSTOM_ERRDESC_BADDOCUMENT";
        private const string FieldCUSTOM_ERR_INTERNALERROR = "CUSTOM_ERR_INTERNALERROR";
        private const string FieldCUSTOM_ERRDESC_INTERNALERROR = "CUSTOM_ERRDESC_INTERNALERROR";
        private const string FieldCUSTOM_ERR_SOURCE_TYPE = "CUSTOM_ERR_SOURCE_TYPE";
        private const string FieldCUSTOM_ERR_TYPE_BUSINESS = "CUSTOM_ERR_TYPE_BUSINESS";
        private const string FieldNODESEARCH_METHODSTATUS = "NODESEARCH_METHODSTATUS";
        private const string FieldNODESEARCH_CONTEXT = "NODESEARCH_CONTEXT";
        private const string FieldNODESEARCH_PARAMETERS = "NODESEARCH_PARAMETERS";
        private const string FieldNODESEARCH_PARAMETERSRETURN = "NODESEARCH_PARAMETERSRETURN";
        private const string FieldXSL_FORMAT = "XSL_FORMAT";
        private const string FieldRESID_BASE_ENC = "RESID_BASE_ENC";
        private const string FieldRESID_BASE = "RESID_BASE";
        private const string FieldRESID_NAME = "RESID_NAME";
        private const string FieldRESID_DESCRIPTION = "RESID_DESCRIPTION";
        private const string FieldRESID_INSTALLEDBY = "RESID_INSTALLEDBY";
        private const string FieldRESID_VERSION = "RESID_VERSION";
        private const string FieldRESID_DATATYPE = "RESID_DATATYPE";
        private const string FieldRESID_OBJECTTYPE = "RESID_OBJECTTYPE";
        private const string FieldRESID_CONTENT = "RESID_CONTENT";
        private const string FieldRESID_INTERNALNAME = "RESID_INTERNALNAME";
        private const string FieldRESID_CONSTRAINTTYPE = "RESID_CONSTRAINTTYPE";
        private const string FieldRESID_STEPTYPE = "RESID_STEPTYPE";
        private const string FieldRESID_STEPDATA = "RESID_STEPDATA";
        private const string FieldRESID_DIRECTION = "RESID_DIRECTION";
        private const string FieldRESID_VALUE = "RESID_VALUE";
        private const string FieldRESID_OBJTYPE = "RESID_OBJTYPE";
        private const string FieldRESID_STEPNAME = "RESID_STEPNAME";
        private const string FieldRESID_ODMTEMPLATE = "RESID_ODMTEMPLATE";
        private const string FieldRESID_OBJKEYTYPE = "RESID_OBJKEYTYPE";
        private const string FieldRESID_METHODTYPE = "RESID_METHODTYPE";
        private const string FieldRESID_COLUMNNAME = "RESID_COLUMNNAME";
        private const string FieldRESID_INITNATLANG = "RESID_INITNATLANG";
        private const string FieldRESID_RELATIONSHIPTYPE = "RESID_RELATIONSHIPTYPE";
        private const string FieldRESID_MULTIPLICITY = "RESID_MULTIPLICITY";
        private const string FieldRESID_CASCADETYPE = "RESID_CASCADETYPE";
        private const string FieldRESID_PRIMKEYTYPE = "RESID_PRIMKEYTYPE";
        private const string FieldRESID_PRIMLITERAL = "RESID_PRIMLITERAL";
        private const string FieldRESID_SECONDKEYTYPE = "RESID_SECONDKEYTYPE";
        private const string FieldRESID_SECONDLITERAL = "RESID_SECONDLITERAL";
        private const string FieldRESID_MAPENTRYTYPE = "RESID_MAPENTRYTYPE";
        private const string FieldRESID_MAPENTRYUSE = "RESID_MAPENTRYUSE";
        private const string FieldRESID_STEPID = "RESID_STEPID";
        private const string FieldRESID_OUTPUTMAPTYPE = "RESID_OUTPUTMAPTYPE";
        private const string FieldRESID_COLUMNTYPE = "RESID_COLUMNTYPE";
        private const string FieldRESID_GENERATEIDTYPE = "RESID_GENERATEIDTYPE";
        private const string FieldRESID_PROCMAPTYPE = "RESID_PROCMAPTYPE";
        private const string FieldRESID_DATABASEACTION = "RESID_DATABASEACTION";
        private const string FieldRESID_PROCEDUREMAPACTION = "RESID_PROCEDUREMAPACTION";
        private const string FieldRESID_SORTDIRECTION = "RESID_SORTDIRECTION";
        private const string FieldRESID_DEFAULT = "RESID_DEFAULT";
        private const string FieldRESID_VALID = "RESID_VALID";
        private const string FieldRESID_RELEASED = "RESID_RELEASED";
        private const string FieldRESID_SYSTEM = "RESID_SYSTEM";
        private const string FieldRESID_DISABLED = "RESID_DISABLED";
        private const string FieldRESID_DOMAINOBJECT = "RESID_DOMAINOBJECT";
        private const string FieldRESID_READONLY = "RESID_READONLY";
        private const string FieldRESID_NOTNULL = "RESID_NOTNULL";
        private const string FieldRESID_WHERECONDITION = "RESID_WHERECONDITION";
        private const string FieldRESID_NEXTOBJECTTYPENUM = "RESID_NEXTOBJECTTYPENUM";
        private const string FieldRESID_COLLECTION = "RESID_COLLECTION";
        private const string FieldRESID_DBENGINE = "RESID_DBENGINE";
        private const string FieldRESID_MINIMUMVERSION = "RESID_MINIMUMVERSION";
        private const string FieldRESID_MULTILANGUAGETABLE = "RESID_MULTILANGUAGETABLE";
        private const string FieldRESID_MAPDATA = "RESID_MAPDATA";
        private const string FieldRESID_MAPID = "RESID_MAPID";
        private const string FieldRESID_MAPMETHODPARID = "RESID_MAPMETHODPARID";
        private const string FieldRESID_MAPPROCPARID = "RESID_MAPPROCPARID";
        private const string FieldMAX_RECURSEDEPTH = "MAX_RECURSEDEPTH";
        private const string FieldmoLog = "moLog";
        private const string FieldmbDebug = "mbDebug";
        private const string FieldmbPerf = "mbPerf";
        private const string FieldmoPerfMeter = "moPerfMeter";
        private const string FieldmoStringResource = "moStringResource";
        private const string FieldmoDOMNameCheck = "moDOMNameCheck";
        private const string FieldmsUserID = "msUserID";
        private const string FieldmsOTMID = "msOTMID";
        private const string FieldmsAction = "msAction";
        private const string FieldmvGenId = "mvGenId";
        private const string FieldmsLBODictionaryNavigation = "msLBODictionaryNavigation";
        private const string FieldmoRelationshipDOM = "moRelationshipDOM";
        private const string FieldmoProcedureMapDOM = "moProcedureMapDOM";
        private const string FieldmoPropertyProcedureMapDOM = "moPropertyProcedureMapDOM";
        private const string FieldmoObjectPhysicalMapsDOM = "moObjectPhysicalMapsDOM";
        private const string FieldmoResultXMLProcMapDOM = "moResultXMLProcMapDOM";
        private const string FieldmNextObjectTypeEnum = "mNextObjectTypeEnum";
        private const string FieldmoContextHelper = "moContextHelper";
        private const string FieldmoStatusHelper = "moStatusHelper";
        private const string FieldmoParamInHelper = "moParamInHelper";
        private const string FieldmoParamOutHelper = "moParamOutHelper";
        private const string FieldmsApplicationName = "msApplicationName";
        private const string FieldmsLogicalObjectName = "msLogicalObjectName";
        private const string FieldmsLogicalMethodName = "msLogicalMethodName";
        private const string FieldmsStepAdditionalData = "msStepAdditionalData";
        private const string FieldmlMutexHandle = "mlMutexHandle";
        private const string FieldmoMethodCollectionPrevious = "moMethodCollectionPrevious";
        private const string FieldmoMethodCollectionCurrent = "moMethodCollectionCurrent";
        private const string FieldmoObjectCollectionCurrent = "moObjectCollectionCurrent";
        private const string FieldmoObjectReferenceStack = "moObjectReferenceStack";
        private const string FieldmvEnumListDataType = "mvEnumListDataType";
        private const string FieldmvEnumListConstraintType = "mvEnumListConstraintType";
        private const string FieldmvEnumListContent = "mvEnumListContent";
        private const string FieldmvEnumListDirection = "mvEnumListDirection";
        private const string FieldmvEnumListStepType = "mvEnumListStepType";
        private const string FieldmvEnumListStepData = "mvEnumListStepData";
        private const string FieldmvEnumSortDirection = "mvEnumSortDirection";
        private const string FieldmvEnumObjectKeyType = "mvEnumObjectKeyType";
        private const string FieldmvEnumMethodType = "mvEnumMethodType";
        private const string FieldmvEnumRelationshipType = "mvEnumRelationshipType";
        private const string FieldmvEnumMultiplicity = "mvEnumMultiplicity";
        private const string FieldmvEnumLogicalCascadeType = "mvEnumLogicalCascadeType";
        private const string FieldmvEnumPrimaryObjectKeyMapType = "mvEnumPrimaryObjectKeyMapType";
        private const string FieldmvEnumSecondaryObjectKeyMapType = "mvEnumSecondaryObjectKeyMapType";
        private const string FieldmvEnumEntryUse = "mvEnumEntryUse";
        private const string FieldmvEnumProcMapEntryType = "mvEnumProcMapEntryType";
        private const string FieldmvEnumObjPhyMapEntryType = "mvEnumObjPhyMapEntryType";
        private const string FieldmvEnumOutputMapType = "mvEnumOutputMapType";
        private const string FieldmvEnumGenerateIdType = "mvEnumGenerateIdType";
        private const string FieldmvEnumProcMapType = "mvEnumProcMapType";
        private const string FieldmvEnumDatabaseAction = "mvEnumDatabaseAction";
        private const string FieldmvEnumProcedureMapAction = "mvEnumProcedureMapAction";
        private const string FieldmvEnumEptDataType = "mvEnumEptDataType";
        private const string FieldmvEnumPhysicalDataType = "mvEnumPhysicalDataType";

        #endregion

        #endregion

        #region General Initializer : Class (Dictionary) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Dictionary" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Dictionary_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Dictionary) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Dictionary" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Dictionary_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Dictionary)

        #region General Initializer : Class (Dictionary) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Dictionary" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodPrintLog, 0)]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodExecuteWithHelpers, 0)]
        [TestCase(MethodLogException, 0)]
        [TestCase(MethodAddSimpleError, 0)]
        [TestCase(MethodEncodeParamsArray, 0)]
        [TestCase(MethodEncodeParams, 0)]
        [TestCase(MethodGetNewID, 0)]
        [TestCase(MethodretrieveGuids, 0)]
        [TestCase(MethodGetNewObjectTypeEnum, 0)]
        [TestCase(MethodFileExists, 0)]
        [TestCase(MethodGetDictionaryFilePath, 0)]
        [TestCase(MethodGetDictionarySchemaPath, 0)]
        [TestCase(MethodGetMethodList, 0)]
        [TestCase(MethodGetMethodListFromObject, 0)]
        [TestCase(MethodClearCollection, 0)]
        [TestCase(MethodBuildDeletedMethodsParameter, 0)]
        [TestCase(MethodLoadDictionaryFromFile, 0)]
        [TestCase(MethodSaveDictionaryToFile, 0)]
        [TestCase(MethodFindObjectByName, 0)]
        [TestCase(MethodFindObjectByID, 0)]
        [TestCase(MethodAddSectionsByID, 0)]
        [TestCase(MethodValidateXMLSection, 0)]
        [TestCase(MethodValidateXML, 0)]
        [TestCase(MethodStoreObjectXMLInDictionary, 0)]
        [TestCase(MethodStoreBusinessObjectXMLInDictionary, 0)]
        [TestCase(MethodDeleteObjectXMLInDictionary, 0)]
        [TestCase(MethodDeleteBusinessObjectXMLInDictionary, 0)]
        [TestCase(MethodDeleteRelationships, 0)]
        [TestCase(MethodCheckUpdateDeletions, 0)]
        [TestCase(MethodDeleteObjectPhysicalMaps, 0)]
        [TestCase(MethodDeleteProcedureMaps, 0)]
        [TestCase(MethodDeleteAllObjectsInDictionary, 0)]
        [TestCase(MethodCheckNextObjectTypeNum, 0)]
        [TestCase(MethodCheckDBEngine, 0)]
        [TestCase(MethodCheckObjectPropertyBoolean, 0)]
        [TestCase(MethodCheckObjectID, 0)]
        [TestCase(MethodCheckObjectTypeEnum, 0)]
        [TestCase(MethodCheckObjectProperty, 0)]
        [TestCase(MethodStringInList, 0)]
        [TestCase(MethodCheckObjectPropertyEnum, 0)]
        [TestCase(MethodCheckNameCharsAndUniqueness, 0)]
        [TestCase(MethodCheckNameUniqueness, 0)]
        [TestCase(MethodCheckNameChars, 0)]
        [TestCase(MethodValidateObject, 0)]
        [TestCase(MethodNameInCollection, 0)]
        [TestCase(MethodNameInCollection, 1)]
        [TestCase(MethodNameInObjectCollection, 0)]
        [TestCase(MethodAddObjectToObjectCollection, 0)]
        [TestCase(MethodDeleteObjectInObjectCollection, 0)]
        [TestCase(MethodGetObjectInfoFromCollection, 0)]
        [TestCase(MethodValidateObjectReferences, 0)]
        [TestCase(MethodGetRelationshipObjectName, 0)]
        [TestCase(MethodValidateRelationshipReferences, 0)]
        [TestCase(MethodGetObjectPhysicalMapName, 0)]
        [TestCase(MethodValidateObjectPhysicalReferences, 0)]
        [TestCase(MethodGetProcedureMapsNames, 0)]
        [TestCase(MethodValidateProcedureMapReferences, 0)]
        [TestCase(MethodMethodCallNotCircular, 0)]
        [TestCase(MethodMethodCallNotCircularRecurse, 0)]
        [TestCase(MethodDownstreamObjectReferenceValid, 0)]
        [TestCase(MethodDownstreamObjectReferenceRecurse, 0)]
        [TestCase(MethodValidateAllObjects, 0)]
        [TestCase(MethodValidateRelationships, 0)]
        [TestCase(MethodValidateObjectPhysicalMaps, 0)]
        [TestCase(MethodValidateProcedureMaps, 0)]
        [TestCase(MethodValidatePhysicalTables, 0)]
        [TestCase(MethodValidatePhysicalProcedures, 0)]
        [TestCase(MethodDoPostChangeProcessing, 0)]
        [TestCase(MethodValidateAllObjectReferences, 0)]
        [TestCase(MethodUpdateValidFlags, 0)]
        [TestCase(MethodMakeRefreshList, 0)]
        [TestCase(MethodCreateEnumsCollection, 0)]
        [TestCase(MethodStringsEqualWithNull, 0)]
        [TestCase(MethodSetReturnProperties, 0)]
        [TestCase(MethodAddSectionsToBO, 0)]
        [TestCase(MethodDoSave, 0)]
        [TestCase(MethodDoDelete, 0)]
        [TestCase(MethodDoSaveCollection, 0)]
        [TestCase(MethodDoRetrieve, 0)]
        [TestCase(MethodDoRetrieveCollection, 0)]
        [TestCase(MethodDoDeleteAll, 0)]
        [TestCase(MethodDoValidateCollection, 0)]
        [TestCase(MethodSetValidationStatus, 0)]
        [TestCase(MethodGetValidationStatus, 0)]
        [TestCase(MethodDoValidateStore, 0)]
        [TestCase(MethodDoPublishToDatabase, 0)]
        [TestCase(MethodCleanUpDanglingPropertiesProcedureMap, 0)]
        [TestCase(MethodCallAOEDCreation, 0)]
        [TestCase(MethodCallSQLGenCreation, 0)]
        [TestCase(MethodDoRetrieveEnums, 0)]
        [TestCase(MethodobjectEqualsNull, 0)]
        [TestCase(MethodBooleansEqualWithNull, 0)]
        public void AUT_Dictionary_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (Dictionary) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Dictionary" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDICTIONARYDAC_LOGID)]
        [TestCase(FieldDICTIONARYDAC_PROGID)]
        [TestCase(FieldDICTIONARYDAC_PROGID_COLON)]
        [TestCase(FieldDICTIONARYDAC_LOCDLL)]
        [TestCase(FieldCONFIGKEY_SUBKEY)]
        [TestCase(FieldCONFIGKEY_DICTIONARYPATH)]
        [TestCase(FieldCONFIGKEY_DICTIONARYWORKINGCOPYPATH)]
        [TestCase(FieldCONFIGKEY_DICTIONARYSCHEMAPATH)]
        [TestCase(FieldCUSTOM_ERR_SOURCE)]
        [TestCase(FieldCUSTOM_VBOBJECTERROR)]
        [TestCase(FieldCUSTOM_ERR_ERRNUMBASE)]
        [TestCase(FieldCUSTOM_ERR_BADDOCUMENT)]
        [TestCase(FieldCUSTOM_ERRDESC_BADDOCUMENT)]
        [TestCase(FieldCUSTOM_ERR_INTERNALERROR)]
        [TestCase(FieldCUSTOM_ERRDESC_INTERNALERROR)]
        [TestCase(FieldCUSTOM_ERR_SOURCE_TYPE)]
        [TestCase(FieldCUSTOM_ERR_TYPE_BUSINESS)]
        [TestCase(FieldNODESEARCH_METHODSTATUS)]
        [TestCase(FieldNODESEARCH_CONTEXT)]
        [TestCase(FieldNODESEARCH_PARAMETERS)]
        [TestCase(FieldNODESEARCH_PARAMETERSRETURN)]
        [TestCase(FieldXSL_FORMAT)]
        [TestCase(FieldRESID_BASE_ENC)]
        [TestCase(FieldRESID_BASE)]
        [TestCase(FieldRESID_NAME)]
        [TestCase(FieldRESID_DESCRIPTION)]
        [TestCase(FieldRESID_INSTALLEDBY)]
        [TestCase(FieldRESID_VERSION)]
        [TestCase(FieldRESID_DATATYPE)]
        [TestCase(FieldRESID_OBJECTTYPE)]
        [TestCase(FieldRESID_CONTENT)]
        [TestCase(FieldRESID_INTERNALNAME)]
        [TestCase(FieldRESID_CONSTRAINTTYPE)]
        [TestCase(FieldRESID_STEPTYPE)]
        [TestCase(FieldRESID_STEPDATA)]
        [TestCase(FieldRESID_DIRECTION)]
        [TestCase(FieldRESID_VALUE)]
        [TestCase(FieldRESID_OBJTYPE)]
        [TestCase(FieldRESID_STEPNAME)]
        [TestCase(FieldRESID_ODMTEMPLATE)]
        [TestCase(FieldRESID_OBJKEYTYPE)]
        [TestCase(FieldRESID_METHODTYPE)]
        [TestCase(FieldRESID_COLUMNNAME)]
        [TestCase(FieldRESID_INITNATLANG)]
        [TestCase(FieldRESID_RELATIONSHIPTYPE)]
        [TestCase(FieldRESID_MULTIPLICITY)]
        [TestCase(FieldRESID_CASCADETYPE)]
        [TestCase(FieldRESID_PRIMKEYTYPE)]
        [TestCase(FieldRESID_PRIMLITERAL)]
        [TestCase(FieldRESID_SECONDKEYTYPE)]
        [TestCase(FieldRESID_SECONDLITERAL)]
        [TestCase(FieldRESID_MAPENTRYTYPE)]
        [TestCase(FieldRESID_MAPENTRYUSE)]
        [TestCase(FieldRESID_STEPID)]
        [TestCase(FieldRESID_OUTPUTMAPTYPE)]
        [TestCase(FieldRESID_COLUMNTYPE)]
        [TestCase(FieldRESID_GENERATEIDTYPE)]
        [TestCase(FieldRESID_PROCMAPTYPE)]
        [TestCase(FieldRESID_DATABASEACTION)]
        [TestCase(FieldRESID_PROCEDUREMAPACTION)]
        [TestCase(FieldRESID_SORTDIRECTION)]
        [TestCase(FieldRESID_DEFAULT)]
        [TestCase(FieldRESID_VALID)]
        [TestCase(FieldRESID_RELEASED)]
        [TestCase(FieldRESID_SYSTEM)]
        [TestCase(FieldRESID_DISABLED)]
        [TestCase(FieldRESID_DOMAINOBJECT)]
        [TestCase(FieldRESID_READONLY)]
        [TestCase(FieldRESID_NOTNULL)]
        [TestCase(FieldRESID_WHERECONDITION)]
        [TestCase(FieldRESID_NEXTOBJECTTYPENUM)]
        [TestCase(FieldRESID_COLLECTION)]
        [TestCase(FieldRESID_DBENGINE)]
        [TestCase(FieldRESID_MINIMUMVERSION)]
        [TestCase(FieldRESID_MULTILANGUAGETABLE)]
        [TestCase(FieldRESID_MAPDATA)]
        [TestCase(FieldRESID_MAPID)]
        [TestCase(FieldRESID_MAPMETHODPARID)]
        [TestCase(FieldRESID_MAPPROCPARID)]
        [TestCase(FieldMAX_RECURSEDEPTH)]
        [TestCase(FieldmoLog)]
        [TestCase(FieldmbDebug)]
        [TestCase(FieldmbPerf)]
        [TestCase(FieldmoPerfMeter)]
        [TestCase(FieldmoStringResource)]
        [TestCase(FieldmoDOMNameCheck)]
        [TestCase(FieldmsUserID)]
        [TestCase(FieldmsOTMID)]
        [TestCase(FieldmsAction)]
        [TestCase(FieldmvGenId)]
        [TestCase(FieldmsLBODictionaryNavigation)]
        [TestCase(FieldmoRelationshipDOM)]
        [TestCase(FieldmoProcedureMapDOM)]
        [TestCase(FieldmoPropertyProcedureMapDOM)]
        [TestCase(FieldmoObjectPhysicalMapsDOM)]
        [TestCase(FieldmoResultXMLProcMapDOM)]
        [TestCase(FieldmNextObjectTypeEnum)]
        [TestCase(FieldmoContextHelper)]
        [TestCase(FieldmoStatusHelper)]
        [TestCase(FieldmoParamInHelper)]
        [TestCase(FieldmoParamOutHelper)]
        [TestCase(FieldmsApplicationName)]
        [TestCase(FieldmsLogicalObjectName)]
        [TestCase(FieldmsLogicalMethodName)]
        [TestCase(FieldmsStepAdditionalData)]
        [TestCase(FieldmlMutexHandle)]
        [TestCase(FieldmoMethodCollectionPrevious)]
        [TestCase(FieldmoMethodCollectionCurrent)]
        [TestCase(FieldmoObjectCollectionCurrent)]
        [TestCase(FieldmoObjectReferenceStack)]
        [TestCase(FieldmvEnumListDataType)]
        [TestCase(FieldmvEnumListConstraintType)]
        [TestCase(FieldmvEnumListContent)]
        [TestCase(FieldmvEnumListDirection)]
        [TestCase(FieldmvEnumListStepType)]
        [TestCase(FieldmvEnumListStepData)]
        [TestCase(FieldmvEnumSortDirection)]
        [TestCase(FieldmvEnumObjectKeyType)]
        [TestCase(FieldmvEnumMethodType)]
        [TestCase(FieldmvEnumRelationshipType)]
        [TestCase(FieldmvEnumMultiplicity)]
        [TestCase(FieldmvEnumLogicalCascadeType)]
        [TestCase(FieldmvEnumPrimaryObjectKeyMapType)]
        [TestCase(FieldmvEnumSecondaryObjectKeyMapType)]
        [TestCase(FieldmvEnumEntryUse)]
        [TestCase(FieldmvEnumProcMapEntryType)]
        [TestCase(FieldmvEnumObjPhyMapEntryType)]
        [TestCase(FieldmvEnumOutputMapType)]
        [TestCase(FieldmvEnumGenerateIdType)]
        [TestCase(FieldmvEnumProcMapType)]
        [TestCase(FieldmvEnumDatabaseAction)]
        [TestCase(FieldmvEnumProcedureMapAction)]
        [TestCase(FieldmvEnumEptDataType)]
        [TestCase(FieldmvEnumPhysicalDataType)]
        [Category("AUT Fields")]
        public void AUT_Dictionary_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Dictionary) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Dictionary" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Dictionary_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dictionaryInstance.ShouldBeAssignableTo<Dictionary>();
            _dictionaryInstanceFixture.ShouldBeAssignableTo<Dictionary>();
            CurrentInstance.ShouldBeAssignableTo<Dictionary>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (PrintLog) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_PrintLog_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintLog);
            var str = this.CreateType<string>();
            var methodPrintLogParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfPrintLog = { str };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPrintLog, parametersOfPrintLog, methodPrintLogParametersTypes);

            // Assert
            parametersOfPrintLog.ShouldNotBeNull();
            parametersOfPrintLog.Length.ShouldBe(1);
            methodPrintLogParametersTypes.Length.ShouldBe(1);
            methodPrintLogParametersTypes.Length.ShouldBe(parametersOfPrintLog.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrintLog) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_PrintLog_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintLog);
            var currentMethodInfo = this.GetMethodInfo(MethodPrintLog, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrintLog) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_PrintLog_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintLog);
            var methodPrintLogParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPrintLog, methodPrintLogParametersTypes);

            // Assert
            methodPrintLogParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrintLog) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_PrintLog_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintLog);
            var currentMethodInfo = this.GetMethodInfo(MethodPrintLog, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_Execute_Method_Call_Internally(Type[] types)
        {
            var methodExecuteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_Execute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var ApplicationName = this.CreateType<string>();
            var LogicalObjectName = this.CreateType<string>();
            var LogicalMethodName = this.CreateType<string>();
            var StepAdditionalData = this.CreateType<string>();
            var XMLString = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { ApplicationName, LogicalObjectName, LogicalMethodName, StepAdditionalData, XMLString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(5);
            methodExecuteParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteWithHelpers) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_ExecuteWithHelpers_Method_Call_Internally(Type[] types)
        {
            var methodExecuteWithHelpersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteWithHelpers, methodExecuteWithHelpersParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteWithHelpers) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ExecuteWithHelpers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithHelpers);
            Type [] methodExecuteWithHelpersParametersTypes = null;
            object[] parametersOfExecuteWithHelpers = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteWithHelpers, methodExecuteWithHelpersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfExecuteWithHelpers);
            var result2 = this.GetResultOfMethod<bool>(MethodExecuteWithHelpers, parametersOfExecuteWithHelpers, methodExecuteWithHelpersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfExecuteWithHelpers.ShouldBeNull();
            methodExecuteWithHelpersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteWithHelpers) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ExecuteWithHelpers_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithHelpers);
            Type [] methodExecuteWithHelpersParametersTypes = null;
            object[] parametersOfExecuteWithHelpers = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteWithHelpers, methodExecuteWithHelpersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfExecuteWithHelpers);
            var result2 = this.GetResultOfMethod<bool>(MethodExecuteWithHelpers, parametersOfExecuteWithHelpers, methodExecuteWithHelpersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfExecuteWithHelpers.ShouldBeNull();
            methodExecuteWithHelpersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteWithHelpers) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ExecuteWithHelpers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithHelpers);
            Type [] methodExecuteWithHelpersParametersTypes = null;
            object[] parametersOfExecuteWithHelpers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodExecuteWithHelpers, parametersOfExecuteWithHelpers, methodExecuteWithHelpersParametersTypes);

            // Assert
            parametersOfExecuteWithHelpers.ShouldBeNull();
            methodExecuteWithHelpersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteWithHelpers) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ExecuteWithHelpers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithHelpers);
            Type [] methodExecuteWithHelpersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteWithHelpers, methodExecuteWithHelpersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteWithHelpersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteWithHelpers) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ExecuteWithHelpers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithHelpers);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteWithHelpers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LogException) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_LogException_Method_Call_Internally(Type[] types)
        {
            var methodLogExceptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogException, methodLogExceptionParametersTypes);
        }

        #endregion

        #region Method Call : (LogException) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_LogException_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogException);
            var MethodName = this.CreateType<string>();
            var AdditionalData = this.CreateType<string>();
            var methodLogExceptionParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfLogException = { MethodName, AdditionalData };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogException, parametersOfLogException, methodLogExceptionParametersTypes);

            // Assert
            parametersOfLogException.ShouldNotBeNull();
            parametersOfLogException.Length.ShouldBe(2);
            methodLogExceptionParametersTypes.Length.ShouldBe(2);
            methodLogExceptionParametersTypes.Length.ShouldBe(parametersOfLogException.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogException) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_LogException_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogException);
            var currentMethodInfo = this.GetMethodInfo(MethodLogException, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogException) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_LogException_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogException);
            var methodLogExceptionParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogException, methodLogExceptionParametersTypes);

            // Assert
            methodLogExceptionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogException) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_LogException_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogException);
            var currentMethodInfo = this.GetMethodInfo(MethodLogException, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddSimpleError) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_AddSimpleError_Method_Call_Internally(Type[] types)
        {
            var methodAddSimpleErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddSimpleError, methodAddSimpleErrorParametersTypes);
        }

        #endregion

        #region Method Call : (AddSimpleError) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSimpleError_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSimpleError);
            var IsFailure = this.CreateType<bool>();
            var LogAsError = this.CreateType<bool>();
            var MethodCall = this.CreateType<string>();
            var ErrorID = this.CreateType<int>();
            var Description = this.CreateType<string>();
            var MsgParams = this.CreateType<string[]>();
            var methodAddSimpleErrorParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(string), typeof(int), typeof(string), typeof(string[]) };
            object[] parametersOfAddSimpleError = { IsFailure, LogAsError, MethodCall, ErrorID, Description, MsgParams };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddSimpleError, methodAddSimpleErrorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfAddSimpleError);
            var result2 = this.GetResultOfMethod<bool>(MethodAddSimpleError, parametersOfAddSimpleError, methodAddSimpleErrorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddSimpleError.ShouldNotBeNull();
            parametersOfAddSimpleError.Length.ShouldBe(6);
            methodAddSimpleErrorParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (AddSimpleError) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSimpleError_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSimpleError);
            var IsFailure = this.CreateType<bool>();
            var LogAsError = this.CreateType<bool>();
            var MethodCall = this.CreateType<string>();
            var ErrorID = this.CreateType<int>();
            var Description = this.CreateType<string>();
            var MsgParams = this.CreateType<string[]>();
            var methodAddSimpleErrorParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(string), typeof(int), typeof(string), typeof(string[]) };
            object[] parametersOfAddSimpleError = { IsFailure, LogAsError, MethodCall, ErrorID, Description, MsgParams };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAddSimpleError, methodAddSimpleErrorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfAddSimpleError);
            var result2 = this.GetResultOfMethod<bool>(MethodAddSimpleError, parametersOfAddSimpleError, methodAddSimpleErrorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddSimpleError.ShouldNotBeNull();
            parametersOfAddSimpleError.Length.ShouldBe(6);
            methodAddSimpleErrorParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (AddSimpleError) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSimpleError_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSimpleError);
            var IsFailure = this.CreateType<bool>();
            var LogAsError = this.CreateType<bool>();
            var MethodCall = this.CreateType<string>();
            var ErrorID = this.CreateType<int>();
            var Description = this.CreateType<string>();
            var MsgParams = this.CreateType<string[]>();
            var methodAddSimpleErrorParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(string), typeof(int), typeof(string), typeof(string[]) };
            object[] parametersOfAddSimpleError = { IsFailure, LogAsError, MethodCall, ErrorID, Description, MsgParams };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddSimpleError, parametersOfAddSimpleError, methodAddSimpleErrorParametersTypes);

            // Assert
            parametersOfAddSimpleError.ShouldNotBeNull();
            parametersOfAddSimpleError.Length.ShouldBe(6);
            methodAddSimpleErrorParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddSimpleError) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSimpleError_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSimpleError);
            var methodAddSimpleErrorParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(string), typeof(int), typeof(string), typeof(string[]) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddSimpleError, methodAddSimpleErrorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddSimpleErrorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddSimpleError) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSimpleError_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSimpleError);
            var currentMethodInfo = this.GetMethodInfo(MethodAddSimpleError, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddSimpleError) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSimpleError_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSimpleError);
            var currentMethodInfo = this.GetMethodInfo(MethodAddSimpleError, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EncodeParamsArray) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_EncodeParamsArray_Method_Call_Internally(Type[] types)
        {
            var methodEncodeParamsArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEncodeParamsArray, methodEncodeParamsArrayParametersTypes);
        }

        #endregion

        #region Method Call : (EncodeParamsArray) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_EncodeParamsArray_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncodeParamsArray);
            var Format = this.CreateType<string>();
            var MsgParams = this.CreateType<string[]>();
            var methodEncodeParamsArrayParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfEncodeParamsArray = { Format, MsgParams };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEncodeParamsArray, parametersOfEncodeParamsArray, methodEncodeParamsArrayParametersTypes);

            // Assert
            parametersOfEncodeParamsArray.ShouldNotBeNull();
            parametersOfEncodeParamsArray.Length.ShouldBe(2);
            methodEncodeParamsArrayParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncodeParamsArray) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_EncodeParamsArray_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncodeParamsArray);
            var methodEncodeParamsArrayParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncodeParamsArray, methodEncodeParamsArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEncodeParamsArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EncodeParamsArray) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_EncodeParamsArray_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncodeParamsArray);
            var currentMethodInfo = this.GetMethodInfo(MethodEncodeParamsArray, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EncodeParams) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_EncodeParams_Method_Call_Internally(Type[] types)
        {
            var methodEncodeParamsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEncodeParams, methodEncodeParamsParametersTypes);
        }

        #endregion

        #region Method Call : (EncodeParams) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_EncodeParams_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncodeParams);
            var Format = this.CreateType<string>();
            var MsgParams = this.CreateType<string[]>();
            var methodEncodeParamsParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfEncodeParams = { Format, MsgParams };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEncodeParams, parametersOfEncodeParams, methodEncodeParamsParametersTypes);

            // Assert
            parametersOfEncodeParams.ShouldNotBeNull();
            parametersOfEncodeParams.Length.ShouldBe(2);
            methodEncodeParamsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncodeParams) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_EncodeParams_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncodeParams);
            var methodEncodeParamsParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncodeParams, methodEncodeParamsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEncodeParamsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EncodeParams) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_EncodeParams_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncodeParams);
            var currentMethodInfo = this.GetMethodInfo(MethodEncodeParams, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNewID) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_GetNewID_Method_Call_Internally(Type[] types)
        {
            var methodGetNewIDParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNewID, methodGetNewIDParametersTypes);
        }

        #endregion

        #region Method Call : (GetNewID) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetNewID_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNewID);
            Type [] methodGetNewIDParametersTypes = null;
            object[] parametersOfGetNewID = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNewID, parametersOfGetNewID, methodGetNewIDParametersTypes);

            // Assert
            parametersOfGetNewID.ShouldBeNull();
            methodGetNewIDParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNewID) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetNewID_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNewID);
            Type [] methodGetNewIDParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNewID, methodGetNewIDParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNewIDParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveGuids) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_retrieveGuids_Method_Call_Internally(Type[] types)
        {
            var methodretrieveGuidsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodretrieveGuids, methodretrieveGuidsParametersTypes);
        }

        #endregion

        #region Method Call : (retrieveGuids) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_retrieveGuids_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveGuids);
            Type [] methodretrieveGuidsParametersTypes = null;
            object[] parametersOfretrieveGuids = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveGuids, methodretrieveGuidsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfretrieveGuids);
            var result2 = this.GetResultOfMethod<bool>(MethodretrieveGuids, parametersOfretrieveGuids, methodretrieveGuidsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfretrieveGuids.ShouldBeNull();
            methodretrieveGuidsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveGuids) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_retrieveGuids_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveGuids);
            Type [] methodretrieveGuidsParametersTypes = null;
            object[] parametersOfretrieveGuids = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveGuids, methodretrieveGuidsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfretrieveGuids);
            var result2 = this.GetResultOfMethod<bool>(MethodretrieveGuids, parametersOfretrieveGuids, methodretrieveGuidsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfretrieveGuids.ShouldBeNull();
            methodretrieveGuidsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveGuids) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_retrieveGuids_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveGuids);
            Type [] methodretrieveGuidsParametersTypes = null;
            object[] parametersOfretrieveGuids = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodretrieveGuids, parametersOfretrieveGuids, methodretrieveGuidsParametersTypes);

            // Assert
            parametersOfretrieveGuids.ShouldBeNull();
            methodretrieveGuidsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveGuids) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_retrieveGuids_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveGuids);
            Type [] methodretrieveGuidsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveGuids, methodretrieveGuidsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveGuidsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveGuids) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_retrieveGuids_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveGuids);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveGuids, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNewObjectTypeEnum) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_GetNewObjectTypeEnum_Method_Call_Internally(Type[] types)
        {
            var methodGetNewObjectTypeEnumParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNewObjectTypeEnum, methodGetNewObjectTypeEnumParametersTypes);
        }

        #endregion

        #region Method Call : (GetNewObjectTypeEnum) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetNewObjectTypeEnum_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNewObjectTypeEnum);
            Type [] methodGetNewObjectTypeEnumParametersTypes = null;
            object[] parametersOfGetNewObjectTypeEnum = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNewObjectTypeEnum, parametersOfGetNewObjectTypeEnum, methodGetNewObjectTypeEnumParametersTypes);

            // Assert
            parametersOfGetNewObjectTypeEnum.ShouldBeNull();
            methodGetNewObjectTypeEnumParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNewObjectTypeEnum) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetNewObjectTypeEnum_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNewObjectTypeEnum);
            Type [] methodGetNewObjectTypeEnumParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNewObjectTypeEnum, methodGetNewObjectTypeEnumParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNewObjectTypeEnumParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileExists) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_FileExists_Method_Call_Internally(Type[] types)
        {
            var methodFileExistsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFileExists, methodFileExistsParametersTypes);
        }

        #endregion

        #region Method Call : (FileExists) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_FileExists_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileExists);
            var Path = this.CreateType<string>();
            var methodFileExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfFileExists = { Path };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFileExists, methodFileExistsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfFileExists);
            var result2 = this.GetResultOfMethod<bool>(MethodFileExists, parametersOfFileExists, methodFileExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFileExists.ShouldNotBeNull();
            parametersOfFileExists.Length.ShouldBe(1);
            methodFileExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FileExists) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_FileExists_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileExists);
            var Path = this.CreateType<string>();
            var methodFileExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfFileExists = { Path };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodFileExists, methodFileExistsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfFileExists);
            var result2 = this.GetResultOfMethod<bool>(MethodFileExists, parametersOfFileExists, methodFileExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFileExists.ShouldNotBeNull();
            parametersOfFileExists.Length.ShouldBe(1);
            methodFileExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (FileExists) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_FileExists_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileExists);
            var Path = this.CreateType<string>();
            var methodFileExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfFileExists = { Path };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodFileExists, parametersOfFileExists, methodFileExistsParametersTypes);

            // Assert
            parametersOfFileExists.ShouldNotBeNull();
            parametersOfFileExists.Length.ShouldBe(1);
            methodFileExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FileExists) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_FileExists_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileExists);
            var methodFileExistsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFileExists, methodFileExistsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFileExistsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FileExists) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_FileExists_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileExists);
            var currentMethodInfo = this.GetMethodInfo(MethodFileExists, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDictionaryFilePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_GetDictionaryFilePath_Method_Call_Internally(Type[] types)
        {
            var methodGetDictionaryFilePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDictionaryFilePath, methodGetDictionaryFilePathParametersTypes);
        }

        #endregion

        #region Method Call : (GetDictionaryFilePath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionaryFilePath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionaryFilePath);
            var ForceRuntime = this.CreateType<bool>();
            var RevertRuntime = this.CreateType<bool>();
            var methodGetDictionaryFilePathParametersTypes = new Type[] { typeof(bool), typeof(bool) };
            object[] parametersOfGetDictionaryFilePath = { ForceRuntime, RevertRuntime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDictionaryFilePath, parametersOfGetDictionaryFilePath, methodGetDictionaryFilePathParametersTypes);

            // Assert
            parametersOfGetDictionaryFilePath.ShouldNotBeNull();
            parametersOfGetDictionaryFilePath.Length.ShouldBe(2);
            methodGetDictionaryFilePathParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDictionaryFilePath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionaryFilePath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionaryFilePath);
            var methodGetDictionaryFilePathParametersTypes = new Type[] { typeof(bool), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDictionaryFilePath, methodGetDictionaryFilePathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDictionaryFilePathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDictionaryFilePath) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionaryFilePath_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionaryFilePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDictionaryFilePath, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDictionarySchemaPath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_GetDictionarySchemaPath_Method_Call_Internally(Type[] types)
        {
            var methodGetDictionarySchemaPathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDictionarySchemaPath, methodGetDictionarySchemaPathParametersTypes);
        }

        #endregion

        #region Method Call : (GetDictionarySchemaPath) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionarySchemaPath_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionarySchemaPath);
            Type [] methodGetDictionarySchemaPathParametersTypes = null;
            object[] parametersOfGetDictionarySchemaPath = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDictionarySchemaPath, methodGetDictionarySchemaPathParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_dictionaryInstanceFixture, parametersOfGetDictionarySchemaPath);
            var result2 = this.GetResultOfMethod<string>(MethodGetDictionarySchemaPath, parametersOfGetDictionarySchemaPath, methodGetDictionarySchemaPathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDictionarySchemaPath.ShouldBeNull();
            methodGetDictionarySchemaPathParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDictionarySchemaPath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionarySchemaPath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionarySchemaPath);
            Type [] methodGetDictionarySchemaPathParametersTypes = null;
            object[] parametersOfGetDictionarySchemaPath = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDictionarySchemaPath, parametersOfGetDictionarySchemaPath, methodGetDictionarySchemaPathParametersTypes);

            // Assert
            parametersOfGetDictionarySchemaPath.ShouldBeNull();
            methodGetDictionarySchemaPathParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDictionarySchemaPath) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionarySchemaPath_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionarySchemaPath);
            Type [] methodGetDictionarySchemaPathParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDictionarySchemaPath, methodGetDictionarySchemaPathParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDictionarySchemaPathParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDictionarySchemaPath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionarySchemaPath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionarySchemaPath);
            Type [] methodGetDictionarySchemaPathParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDictionarySchemaPath, methodGetDictionarySchemaPathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDictionarySchemaPathParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDictionarySchemaPath) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetDictionarySchemaPath_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDictionarySchemaPath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDictionarySchemaPath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMethodList) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_GetMethodList_Method_Call_Internally(Type[] types)
        {
            var methodGetMethodListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMethodList, methodGetMethodListParametersTypes);
        }

        #endregion
        
        #region Method Call : (GetMethodListFromObject) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetMethodListFromObject_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodListFromObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodListFromObject, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearCollection) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_ClearCollection_Method_Call_Internally(Type[] types)
        {
            var methodClearCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClearCollection, methodClearCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (ClearCollection) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ClearCollection_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCollection);
            var ObjectList = this.CreateType<OrderedDictionary>();
            var methodClearCollectionParametersTypes = new Type[] { typeof(OrderedDictionary) };
            object[] parametersOfClearCollection = { ObjectList };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearCollection, parametersOfClearCollection, methodClearCollectionParametersTypes);

            // Assert
            parametersOfClearCollection.ShouldNotBeNull();
            parametersOfClearCollection.Length.ShouldBe(1);
            methodClearCollectionParametersTypes.Length.ShouldBe(1);
            methodClearCollectionParametersTypes.Length.ShouldBe(parametersOfClearCollection.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearCollection) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ClearCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodClearCollection, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ClearCollection) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ClearCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCollection);
            var methodClearCollectionParametersTypes = new Type[] { typeof(OrderedDictionary) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearCollection, methodClearCollectionParametersTypes);

            // Assert
            methodClearCollectionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearCollection) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ClearCollection_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodClearCollection, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildDeletedMethodsParameter) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_BuildDeletedMethodsParameter_Method_Call_Internally(Type[] types)
        {
            var methodBuildDeletedMethodsParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildDeletedMethodsParameter, methodBuildDeletedMethodsParameterParametersTypes);
        }

        #endregion

        #region Method Call : (BuildDeletedMethodsParameter) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BuildDeletedMethodsParameter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildDeletedMethodsParameter);
            Type [] methodBuildDeletedMethodsParameterParametersTypes = null;
            object[] parametersOfBuildDeletedMethodsParameter = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildDeletedMethodsParameter, methodBuildDeletedMethodsParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfBuildDeletedMethodsParameter);
            var result2 = this.GetResultOfMethod<bool>(MethodBuildDeletedMethodsParameter, parametersOfBuildDeletedMethodsParameter, methodBuildDeletedMethodsParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBuildDeletedMethodsParameter.ShouldBeNull();
            methodBuildDeletedMethodsParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BuildDeletedMethodsParameter) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BuildDeletedMethodsParameter_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildDeletedMethodsParameter);
            Type [] methodBuildDeletedMethodsParameterParametersTypes = null;
            object[] parametersOfBuildDeletedMethodsParameter = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildDeletedMethodsParameter, methodBuildDeletedMethodsParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfBuildDeletedMethodsParameter);
            var result2 = this.GetResultOfMethod<bool>(MethodBuildDeletedMethodsParameter, parametersOfBuildDeletedMethodsParameter, methodBuildDeletedMethodsParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBuildDeletedMethodsParameter.ShouldBeNull();
            methodBuildDeletedMethodsParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BuildDeletedMethodsParameter) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BuildDeletedMethodsParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildDeletedMethodsParameter);
            Type [] methodBuildDeletedMethodsParameterParametersTypes = null;
            object[] parametersOfBuildDeletedMethodsParameter = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodBuildDeletedMethodsParameter, parametersOfBuildDeletedMethodsParameter, methodBuildDeletedMethodsParameterParametersTypes);

            // Assert
            parametersOfBuildDeletedMethodsParameter.ShouldBeNull();
            methodBuildDeletedMethodsParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildDeletedMethodsParameter) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BuildDeletedMethodsParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildDeletedMethodsParameter);
            Type [] methodBuildDeletedMethodsParameterParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildDeletedMethodsParameter, methodBuildDeletedMethodsParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBuildDeletedMethodsParameterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BuildDeletedMethodsParameter) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BuildDeletedMethodsParameter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildDeletedMethodsParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildDeletedMethodsParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LoadDictionaryFromFile) (Return Type : DOMHelper) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_LoadDictionaryFromFile_Method_Call_Internally(Type[] types)
        {
            var methodLoadDictionaryFromFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLoadDictionaryFromFile, methodLoadDictionaryFromFileParametersTypes);
        }

        #endregion

        #region Method Call : (AddSectionsByID) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSectionsByID_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSectionsByID);
            var currentMethodInfo = this.GetMethodInfo(MethodAddSectionsByID, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateXMLSection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_ValidateXMLSection_Method_Call_Internally(Type[] types)
        {
            var methodValidateXMLSectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateXMLSection, methodValidateXMLSectionParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateXMLSection) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXMLSection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXMLSection);
            var sQualifiedXML = this.CreateType<string>();
            var methodValidateXMLSectionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfValidateXMLSection = { sQualifiedXML };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXMLSection, methodValidateXMLSectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfValidateXMLSection);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateXMLSection, parametersOfValidateXMLSection, methodValidateXMLSectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateXMLSection.ShouldNotBeNull();
            parametersOfValidateXMLSection.Length.ShouldBe(1);
            methodValidateXMLSectionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateXMLSection) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXMLSection_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXMLSection);
            var sQualifiedXML = this.CreateType<string>();
            var methodValidateXMLSectionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfValidateXMLSection = { sQualifiedXML };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXMLSection, methodValidateXMLSectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfValidateXMLSection);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateXMLSection, parametersOfValidateXMLSection, methodValidateXMLSectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateXMLSection.ShouldNotBeNull();
            parametersOfValidateXMLSection.Length.ShouldBe(1);
            methodValidateXMLSectionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateXMLSection) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXMLSection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXMLSection);
            var sQualifiedXML = this.CreateType<string>();
            var methodValidateXMLSectionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfValidateXMLSection = { sQualifiedXML };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodValidateXMLSection, parametersOfValidateXMLSection, methodValidateXMLSectionParametersTypes);

            // Assert
            parametersOfValidateXMLSection.ShouldNotBeNull();
            parametersOfValidateXMLSection.Length.ShouldBe(1);
            methodValidateXMLSectionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateXMLSection) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXMLSection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXMLSection);
            var methodValidateXMLSectionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateXMLSection, methodValidateXMLSectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateXMLSectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateXMLSection) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXMLSection_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXMLSection);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXMLSection, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateXMLSection) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXMLSection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXMLSection);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXMLSection, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateXML) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_ValidateXML_Method_Call_Internally(Type[] types)
        {
            var methodValidateXMLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateXML, methodValidateXMLParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateXML) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXML_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXML);
            var ObjectXML = this.CreateType<string>();
            var oDOM = this.CreateType<FreeThreadedDOMDocument60>();
            var methodValidateXMLParametersTypes = new Type[] { typeof(string), typeof(FreeThreadedDOMDocument60) };
            object[] parametersOfValidateXML = { ObjectXML, oDOM };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXML, methodValidateXMLParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfValidateXML);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateXML, parametersOfValidateXML, methodValidateXMLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateXML.ShouldNotBeNull();
            parametersOfValidateXML.Length.ShouldBe(2);
            methodValidateXMLParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateXML) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXML_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXML);
            var ObjectXML = this.CreateType<string>();
            var oDOM = this.CreateType<FreeThreadedDOMDocument60>();
            var methodValidateXMLParametersTypes = new Type[] { typeof(string), typeof(FreeThreadedDOMDocument60) };
            object[] parametersOfValidateXML = { ObjectXML, oDOM };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXML, methodValidateXMLParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfValidateXML);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateXML, parametersOfValidateXML, methodValidateXMLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateXML.ShouldNotBeNull();
            parametersOfValidateXML.Length.ShouldBe(2);
            methodValidateXMLParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateXML) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXML_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXML);
            var ObjectXML = this.CreateType<string>();
            var oDOM = this.CreateType<FreeThreadedDOMDocument60>();
            var methodValidateXMLParametersTypes = new Type[] { typeof(string), typeof(FreeThreadedDOMDocument60) };
            object[] parametersOfValidateXML = { ObjectXML, oDOM };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodValidateXML, parametersOfValidateXML, methodValidateXMLParametersTypes);

            // Assert
            parametersOfValidateXML.ShouldNotBeNull();
            parametersOfValidateXML.Length.ShouldBe(2);
            methodValidateXMLParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateXML) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXML_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXML);
            var methodValidateXMLParametersTypes = new Type[] { typeof(string), typeof(FreeThreadedDOMDocument60) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateXML, methodValidateXMLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateXMLParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateXML) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXML_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXML);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXML, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateXML) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateXML_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXML);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXML, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StoreObjectXMLInDictionary) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_StoreObjectXMLInDictionary_Method_Call_Internally(Type[] types)
        {
            var methodStoreObjectXMLInDictionaryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStoreObjectXMLInDictionary, methodStoreObjectXMLInDictionaryParametersTypes);
        }

        #endregion

        #region Method Call : (CheckObjectProperty) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckObjectProperty_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckObjectProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckObjectProperty, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StringInList) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_StringInList_Method_Call_Internally(Type[] types)
        {
            var methodStringInListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStringInList, methodStringInListParametersTypes);
        }

        #endregion

        #region Method Call : (StringInList) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringInList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringInList);
            var Value = this.CreateType<string>();
            var EnumList = this.CreateType<string[]>();
            var methodStringInListParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfStringInList = { Value, EnumList };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodStringInList, methodStringInListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfStringInList);
            var result2 = this.GetResultOfMethod<bool>(MethodStringInList, parametersOfStringInList, methodStringInListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfStringInList.ShouldNotBeNull();
            parametersOfStringInList.Length.ShouldBe(2);
            methodStringInListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (StringInList) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringInList_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringInList);
            var Value = this.CreateType<string>();
            var EnumList = this.CreateType<string[]>();
            var methodStringInListParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfStringInList = { Value, EnumList };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodStringInList, methodStringInListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfStringInList);
            var result2 = this.GetResultOfMethod<bool>(MethodStringInList, parametersOfStringInList, methodStringInListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfStringInList.ShouldNotBeNull();
            parametersOfStringInList.Length.ShouldBe(2);
            methodStringInListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (StringInList) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringInList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringInList);
            var Value = this.CreateType<string>();
            var EnumList = this.CreateType<string[]>();
            var methodStringInListParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfStringInList = { Value, EnumList };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodStringInList, parametersOfStringInList, methodStringInListParametersTypes);

            // Assert
            parametersOfStringInList.ShouldNotBeNull();
            parametersOfStringInList.Length.ShouldBe(2);
            methodStringInListParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StringInList) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringInList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringInList);
            var methodStringInListParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStringInList, methodStringInListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodStringInListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StringInList) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringInList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringInList);
            var currentMethodInfo = this.GetMethodInfo(MethodStringInList, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckObjectPropertyEnum) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_CheckObjectPropertyEnum_Method_Call_Internally(Type[] types)
        {
            var methodCheckObjectPropertyEnumParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckObjectPropertyEnum, methodCheckObjectPropertyEnumParametersTypes);
        }

        #endregion
        
        #region Method Call : (CheckObjectPropertyEnum) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckObjectPropertyEnum_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckObjectPropertyEnum);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckObjectPropertyEnum, 0);
            const int parametersCount = 9;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (CheckObjectPropertyEnum) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckObjectPropertyEnum_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckObjectPropertyEnum);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckObjectPropertyEnum, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameCharsAndUniqueness) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_CheckNameCharsAndUniqueness_Method_Call_Internally(Type[] types)
        {
            var methodCheckNameCharsAndUniquenessParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckNameCharsAndUniqueness, methodCheckNameCharsAndUniquenessParametersTypes);
        }

        #endregion

        #region Method Call : (CheckNameCharsAndUniqueness) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameCharsAndUniqueness_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameCharsAndUniqueness);
            var Silent = this.CreateType<bool>();
            var ItemDesc = this.CreateType<string>();
            var name = this.CreateType<string>();
            var NameCollection = this.CreateType<OrderedDictionary>();
            var Invalid = this.CreateType<bool>();
            var methodCheckNameCharsAndUniquenessParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(string), typeof(OrderedDictionary), typeof(bool) };
            object[] parametersOfCheckNameCharsAndUniqueness = { Silent, ItemDesc, name, NameCollection, Invalid };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCheckNameCharsAndUniqueness, parametersOfCheckNameCharsAndUniqueness, methodCheckNameCharsAndUniquenessParametersTypes);

            // Assert
            parametersOfCheckNameCharsAndUniqueness.ShouldNotBeNull();
            parametersOfCheckNameCharsAndUniqueness.Length.ShouldBe(5);
            methodCheckNameCharsAndUniquenessParametersTypes.Length.ShouldBe(5);
            methodCheckNameCharsAndUniquenessParametersTypes.Length.ShouldBe(parametersOfCheckNameCharsAndUniqueness.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameCharsAndUniqueness) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameCharsAndUniqueness_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameCharsAndUniqueness);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckNameCharsAndUniqueness, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckNameCharsAndUniqueness) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameCharsAndUniqueness_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameCharsAndUniqueness);
            var methodCheckNameCharsAndUniquenessParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(string), typeof(OrderedDictionary), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckNameCharsAndUniqueness, methodCheckNameCharsAndUniquenessParametersTypes);

            // Assert
            methodCheckNameCharsAndUniquenessParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameCharsAndUniqueness) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameCharsAndUniqueness_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameCharsAndUniqueness);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckNameCharsAndUniqueness, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameUniqueness) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_CheckNameUniqueness_Method_Call_Internally(Type[] types)
        {
            var methodCheckNameUniquenessParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckNameUniqueness, methodCheckNameUniquenessParametersTypes);
        }

        #endregion

        #region Method Call : (CheckNameUniqueness) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameUniqueness_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameUniqueness);
            var Silent = this.CreateType<bool>();
            var ItemDesc = this.CreateType<string>();
            var name = this.CreateType<string>();
            var NameCollection = this.CreateType<OrderedDictionary>();
            var Invalid = this.CreateType<bool>();
            var methodCheckNameUniquenessParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(string), typeof(OrderedDictionary), typeof(bool) };
            object[] parametersOfCheckNameUniqueness = { Silent, ItemDesc, name, NameCollection, Invalid };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCheckNameUniqueness, parametersOfCheckNameUniqueness, methodCheckNameUniquenessParametersTypes);

            // Assert
            parametersOfCheckNameUniqueness.ShouldNotBeNull();
            parametersOfCheckNameUniqueness.Length.ShouldBe(5);
            methodCheckNameUniquenessParametersTypes.Length.ShouldBe(5);
            methodCheckNameUniquenessParametersTypes.Length.ShouldBe(parametersOfCheckNameUniqueness.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameUniqueness) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameUniqueness_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameUniqueness);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckNameUniqueness, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckNameUniqueness) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameUniqueness_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameUniqueness);
            var methodCheckNameUniquenessParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(string), typeof(OrderedDictionary), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckNameUniqueness, methodCheckNameUniquenessParametersTypes);

            // Assert
            methodCheckNameUniquenessParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameUniqueness) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameUniqueness_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameUniqueness);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckNameUniqueness, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameChars) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_CheckNameChars_Method_Call_Internally(Type[] types)
        {
            var methodCheckNameCharsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckNameChars, methodCheckNameCharsParametersTypes);
        }

        #endregion

        #region Method Call : (CheckNameChars) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameChars_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameChars);
            var Silent = this.CreateType<bool>();
            var ItemDesc = this.CreateType<string>();
            var name = this.CreateType<string>();
            var Invalid = this.CreateType<bool>();
            var methodCheckNameCharsParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfCheckNameChars = { Silent, ItemDesc, name, Invalid };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCheckNameChars, parametersOfCheckNameChars, methodCheckNameCharsParametersTypes);

            // Assert
            parametersOfCheckNameChars.ShouldNotBeNull();
            parametersOfCheckNameChars.Length.ShouldBe(4);
            methodCheckNameCharsParametersTypes.Length.ShouldBe(4);
            methodCheckNameCharsParametersTypes.Length.ShouldBe(parametersOfCheckNameChars.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameChars) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameChars_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameChars);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckNameChars, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckNameChars) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameChars_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameChars);
            var methodCheckNameCharsParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(string), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckNameChars, methodCheckNameCharsParametersTypes);

            // Assert
            methodCheckNameCharsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckNameChars) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CheckNameChars_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckNameChars);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckNameChars, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateObject) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_ValidateObject_Method_Call_Internally(Type[] types)
        {
            var methodValidateObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateObject, methodValidateObjectParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateObject) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateObject_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateObject) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateObject_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateObject, 0);
            const int parametersCount = 11;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_NameInCollection_Method_Call_Internally(Type[] types)
        {
            var methodNameInCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodNameInCollection, methodNameInCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodNameInCollection, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_NameInCollection_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodNameInCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodNameInCollection, methodNameInCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInCollection_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInCollection);
            var name = this.CreateType<string>();
            var NameCollection = this.CreateType<OrderedDictionary>();
            var methodNameInCollectionParametersTypes = new Type[] { typeof(string), typeof(OrderedDictionary) };
            object[] parametersOfNameInCollection = { name, NameCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodNameInCollection, methodNameInCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfNameInCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodNameInCollection, parametersOfNameInCollection, methodNameInCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfNameInCollection.ShouldNotBeNull();
            parametersOfNameInCollection.Length.ShouldBe(2);
            methodNameInCollectionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInCollection_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInCollection);
            var name = this.CreateType<string>();
            var NameCollection = this.CreateType<OrderedDictionary>();
            var methodNameInCollectionParametersTypes = new Type[] { typeof(string), typeof(OrderedDictionary) };
            object[] parametersOfNameInCollection = { name, NameCollection };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodNameInCollection, methodNameInCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfNameInCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodNameInCollection, parametersOfNameInCollection, methodNameInCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfNameInCollection.ShouldNotBeNull();
            parametersOfNameInCollection.Length.ShouldBe(2);
            methodNameInCollectionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInCollection_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInCollection);
            var name = this.CreateType<string>();
            var NameCollection = this.CreateType<OrderedDictionary>();
            var methodNameInCollectionParametersTypes = new Type[] { typeof(string), typeof(OrderedDictionary) };
            object[] parametersOfNameInCollection = { name, NameCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodNameInCollection, parametersOfNameInCollection, methodNameInCollectionParametersTypes);

            // Assert
            parametersOfNameInCollection.ShouldNotBeNull();
            parametersOfNameInCollection.Length.ShouldBe(2);
            methodNameInCollectionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInCollection_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInCollection);
            var methodNameInCollectionParametersTypes = new Type[] { typeof(string), typeof(OrderedDictionary) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodNameInCollection, methodNameInCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodNameInCollectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (NameInCollection) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInCollection_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodNameInCollection, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (NameInObjectCollection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_NameInObjectCollection_Method_Call_Internally(Type[] types)
        {
            var methodNameInObjectCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodNameInObjectCollection, methodNameInObjectCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (NameInObjectCollection) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInObjectCollection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInObjectCollection);
            var definitionType = this.CreateType<string>();
            var name = this.CreateType<string>();
            var ObjectCollection = this.CreateType<OrderedDictionary>();
            var methodNameInObjectCollectionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(OrderedDictionary) };
            object[] parametersOfNameInObjectCollection = { definitionType, name, ObjectCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodNameInObjectCollection, methodNameInObjectCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfNameInObjectCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodNameInObjectCollection, parametersOfNameInObjectCollection, methodNameInObjectCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfNameInObjectCollection.ShouldNotBeNull();
            parametersOfNameInObjectCollection.Length.ShouldBe(3);
            methodNameInObjectCollectionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (NameInObjectCollection) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInObjectCollection_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInObjectCollection);
            var definitionType = this.CreateType<string>();
            var name = this.CreateType<string>();
            var ObjectCollection = this.CreateType<OrderedDictionary>();
            var methodNameInObjectCollectionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(OrderedDictionary) };
            object[] parametersOfNameInObjectCollection = { definitionType, name, ObjectCollection };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodNameInObjectCollection, methodNameInObjectCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfNameInObjectCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodNameInObjectCollection, parametersOfNameInObjectCollection, methodNameInObjectCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfNameInObjectCollection.ShouldNotBeNull();
            parametersOfNameInObjectCollection.Length.ShouldBe(3);
            methodNameInObjectCollectionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (NameInObjectCollection) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInObjectCollection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInObjectCollection);
            var definitionType = this.CreateType<string>();
            var name = this.CreateType<string>();
            var ObjectCollection = this.CreateType<OrderedDictionary>();
            var methodNameInObjectCollectionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(OrderedDictionary) };
            object[] parametersOfNameInObjectCollection = { definitionType, name, ObjectCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodNameInObjectCollection, parametersOfNameInObjectCollection, methodNameInObjectCollectionParametersTypes);

            // Assert
            parametersOfNameInObjectCollection.ShouldNotBeNull();
            parametersOfNameInObjectCollection.Length.ShouldBe(3);
            methodNameInObjectCollectionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (NameInObjectCollection) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInObjectCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInObjectCollection);
            var methodNameInObjectCollectionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(OrderedDictionary) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodNameInObjectCollection, methodNameInObjectCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodNameInObjectCollectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (NameInObjectCollection) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_NameInObjectCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodNameInObjectCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodNameInObjectCollection, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddObjectToObjectCollection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_AddObjectToObjectCollection_Method_Call_Internally(Type[] types)
        {
            var methodAddObjectToObjectCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddObjectToObjectCollection, methodAddObjectToObjectCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (AddObjectToObjectCollection) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddObjectToObjectCollection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectToObjectCollection);
            var ObjectCollection = this.CreateType<OrderedDictionary>();
            var ObjectID = this.CreateType<string>();
            var name = this.CreateType<string>();
            var Valid = this.CreateType<bool>();
            var Disabled = this.CreateType<bool>();
            var ReferencesValid = this.CreateType<bool>();
            var ReferencesChecked = this.CreateType<bool>();
            var ObjectChanged = this.CreateType<bool>();
            var definitionType = this.CreateType<string>();
            var methodAddObjectToObjectCollectionParametersTypes = new Type[] { typeof(OrderedDictionary), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string) };
            object[] parametersOfAddObjectToObjectCollection = { ObjectCollection, ObjectID, name, Valid, Disabled, ReferencesValid, ReferencesChecked, ObjectChanged, definitionType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddObjectToObjectCollection, methodAddObjectToObjectCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfAddObjectToObjectCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodAddObjectToObjectCollection, parametersOfAddObjectToObjectCollection, methodAddObjectToObjectCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddObjectToObjectCollection.ShouldNotBeNull();
            parametersOfAddObjectToObjectCollection.Length.ShouldBe(9);
            methodAddObjectToObjectCollectionParametersTypes.Length.ShouldBe(9);
        }

        #endregion

        #region Method Call : (AddObjectToObjectCollection) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddObjectToObjectCollection_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectToObjectCollection);
            var ObjectCollection = this.CreateType<OrderedDictionary>();
            var ObjectID = this.CreateType<string>();
            var name = this.CreateType<string>();
            var Valid = this.CreateType<bool>();
            var Disabled = this.CreateType<bool>();
            var ReferencesValid = this.CreateType<bool>();
            var ReferencesChecked = this.CreateType<bool>();
            var ObjectChanged = this.CreateType<bool>();
            var definitionType = this.CreateType<string>();
            var methodAddObjectToObjectCollectionParametersTypes = new Type[] { typeof(OrderedDictionary), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string) };
            object[] parametersOfAddObjectToObjectCollection = { ObjectCollection, ObjectID, name, Valid, Disabled, ReferencesValid, ReferencesChecked, ObjectChanged, definitionType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAddObjectToObjectCollection, methodAddObjectToObjectCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfAddObjectToObjectCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodAddObjectToObjectCollection, parametersOfAddObjectToObjectCollection, methodAddObjectToObjectCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddObjectToObjectCollection.ShouldNotBeNull();
            parametersOfAddObjectToObjectCollection.Length.ShouldBe(9);
            methodAddObjectToObjectCollectionParametersTypes.Length.ShouldBe(9);
        }

        #endregion

        #region Method Call : (AddObjectToObjectCollection) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddObjectToObjectCollection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectToObjectCollection);
            var ObjectCollection = this.CreateType<OrderedDictionary>();
            var ObjectID = this.CreateType<string>();
            var name = this.CreateType<string>();
            var Valid = this.CreateType<bool>();
            var Disabled = this.CreateType<bool>();
            var ReferencesValid = this.CreateType<bool>();
            var ReferencesChecked = this.CreateType<bool>();
            var ObjectChanged = this.CreateType<bool>();
            var definitionType = this.CreateType<string>();
            var methodAddObjectToObjectCollectionParametersTypes = new Type[] { typeof(OrderedDictionary), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string) };
            object[] parametersOfAddObjectToObjectCollection = { ObjectCollection, ObjectID, name, Valid, Disabled, ReferencesValid, ReferencesChecked, ObjectChanged, definitionType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddObjectToObjectCollection, parametersOfAddObjectToObjectCollection, methodAddObjectToObjectCollectionParametersTypes);

            // Assert
            parametersOfAddObjectToObjectCollection.ShouldNotBeNull();
            parametersOfAddObjectToObjectCollection.Length.ShouldBe(9);
            methodAddObjectToObjectCollectionParametersTypes.Length.ShouldBe(9);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddObjectToObjectCollection) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddObjectToObjectCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectToObjectCollection);
            var methodAddObjectToObjectCollectionParametersTypes = new Type[] { typeof(OrderedDictionary), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string) };
            const int parametersCount = 9;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddObjectToObjectCollection, methodAddObjectToObjectCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddObjectToObjectCollectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddObjectToObjectCollection) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddObjectToObjectCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddObjectToObjectCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodAddObjectToObjectCollection, 0);
            const int parametersCount = 9;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteObjectInObjectCollection) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DeleteObjectInObjectCollection_Method_Call_Internally(Type[] types)
        {
            var methodDeleteObjectInObjectCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteObjectInObjectCollection, methodDeleteObjectInObjectCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteObjectInObjectCollection) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DeleteObjectInObjectCollection_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteObjectInObjectCollection);
            var definitionType = this.CreateType<string>();
            var name = this.CreateType<string>();
            var ObjectCollection = this.CreateType<OrderedDictionary>();
            var methodDeleteObjectInObjectCollectionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(OrderedDictionary) };
            object[] parametersOfDeleteObjectInObjectCollection = { definitionType, name, ObjectCollection };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteObjectInObjectCollection, parametersOfDeleteObjectInObjectCollection, methodDeleteObjectInObjectCollectionParametersTypes);

            // Assert
            parametersOfDeleteObjectInObjectCollection.ShouldNotBeNull();
            parametersOfDeleteObjectInObjectCollection.Length.ShouldBe(3);
            methodDeleteObjectInObjectCollectionParametersTypes.Length.ShouldBe(3);
            methodDeleteObjectInObjectCollectionParametersTypes.Length.ShouldBe(parametersOfDeleteObjectInObjectCollection.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteObjectInObjectCollection) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DeleteObjectInObjectCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteObjectInObjectCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteObjectInObjectCollection, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteObjectInObjectCollection) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DeleteObjectInObjectCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteObjectInObjectCollection);
            var methodDeleteObjectInObjectCollectionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(OrderedDictionary) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteObjectInObjectCollection, methodDeleteObjectInObjectCollectionParametersTypes);

            // Assert
            methodDeleteObjectInObjectCollectionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteObjectInObjectCollection) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DeleteObjectInObjectCollection_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteObjectInObjectCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteObjectInObjectCollection, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInfoFromCollection) (Return Type : ObjectInfo) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_GetObjectInfoFromCollection_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectInfoFromCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectInfoFromCollection, methodGetObjectInfoFromCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateRelationshipReferences) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_ValidateRelationshipReferences_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateRelationshipReferences);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateRelationshipReferences, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectPhysicalMapName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_GetObjectPhysicalMapName_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectPhysicalMapNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectPhysicalMapName, methodGetObjectPhysicalMapNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectPhysicalMapName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetObjectPhysicalMapName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectPhysicalMapName);
            var oBONode = this.CreateType<MSXML2.IXMLDOMNode>();
            var mapNode = this.CreateType<MSXML2.IXMLDOMNode>();
            var methodGetObjectPhysicalMapNameParametersTypes = new Type[] { typeof(MSXML2.IXMLDOMNode), typeof(MSXML2.IXMLDOMNode) };
            object[] parametersOfGetObjectPhysicalMapName = { oBONode, mapNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetObjectPhysicalMapName, parametersOfGetObjectPhysicalMapName, methodGetObjectPhysicalMapNameParametersTypes);

            // Assert
            parametersOfGetObjectPhysicalMapName.ShouldNotBeNull();
            parametersOfGetObjectPhysicalMapName.Length.ShouldBe(2);
            methodGetObjectPhysicalMapNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectPhysicalMapName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetObjectPhysicalMapName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectPhysicalMapName);
            var methodGetObjectPhysicalMapNameParametersTypes = new Type[] { typeof(MSXML2.IXMLDOMNode), typeof(MSXML2.IXMLDOMNode) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectPhysicalMapName, methodGetObjectPhysicalMapNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectPhysicalMapNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectPhysicalMapName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetObjectPhysicalMapName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectPhysicalMapName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectPhysicalMapName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateObjectPhysicalReferences) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_ValidateObjectPhysicalReferences_Method_Call_Internally(Type[] types)
        {
            var methodValidateObjectPhysicalReferencesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateObjectPhysicalReferences, methodValidateObjectPhysicalReferencesParametersTypes);
        }

        #endregion
        
        #region Method Call : (StringsEqualWithNull) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringsEqualWithNull_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringsEqualWithNull);
            var Value1 = this.CreateType<string>();
            var Value2 = this.CreateType<string>();
            var methodStringsEqualWithNullParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfStringsEqualWithNull = { Value1, Value2 };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodStringsEqualWithNull, methodStringsEqualWithNullParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfStringsEqualWithNull);
            var result2 = this.GetResultOfMethod<bool>(MethodStringsEqualWithNull, parametersOfStringsEqualWithNull, methodStringsEqualWithNullParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfStringsEqualWithNull.ShouldNotBeNull();
            parametersOfStringsEqualWithNull.Length.ShouldBe(2);
            methodStringsEqualWithNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (StringsEqualWithNull) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringsEqualWithNull_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringsEqualWithNull);
            var Value1 = this.CreateType<string>();
            var Value2 = this.CreateType<string>();
            var methodStringsEqualWithNullParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfStringsEqualWithNull = { Value1, Value2 };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodStringsEqualWithNull, methodStringsEqualWithNullParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfStringsEqualWithNull);
            var result2 = this.GetResultOfMethod<bool>(MethodStringsEqualWithNull, parametersOfStringsEqualWithNull, methodStringsEqualWithNullParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfStringsEqualWithNull.ShouldNotBeNull();
            parametersOfStringsEqualWithNull.Length.ShouldBe(2);
            methodStringsEqualWithNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (StringsEqualWithNull) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringsEqualWithNull_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringsEqualWithNull);
            var Value1 = this.CreateType<string>();
            var Value2 = this.CreateType<string>();
            var methodStringsEqualWithNullParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfStringsEqualWithNull = { Value1, Value2 };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodStringsEqualWithNull, parametersOfStringsEqualWithNull, methodStringsEqualWithNullParametersTypes);

            // Assert
            parametersOfStringsEqualWithNull.ShouldNotBeNull();
            parametersOfStringsEqualWithNull.Length.ShouldBe(2);
            methodStringsEqualWithNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StringsEqualWithNull) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringsEqualWithNull_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringsEqualWithNull);
            var methodStringsEqualWithNullParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStringsEqualWithNull, methodStringsEqualWithNullParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodStringsEqualWithNullParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StringsEqualWithNull) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_StringsEqualWithNull_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringsEqualWithNull);
            var currentMethodInfo = this.GetMethodInfo(MethodStringsEqualWithNull, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetReturnProperties) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_SetReturnProperties_Method_Call_Internally(Type[] types)
        {
            var methodSetReturnPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetReturnProperties, methodSetReturnPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (AddSectionsToBO) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSectionsToBO_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSectionsToBO);
            var currentMethodInfo = this.GetMethodInfo(MethodAddSectionsToBO, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddSectionsToBO) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_AddSectionsToBO_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddSectionsToBO);
            var currentMethodInfo = this.GetMethodInfo(MethodAddSectionsToBO, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoSave) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoSave_Method_Call_Internally(Type[] types)
        {
            var methodDoSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoSave, methodDoSaveParametersTypes);
        }

        #endregion

        #region Method Call : (DoSave) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSave_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSave);
            Type [] methodDoSaveParametersTypes = null;
            object[] parametersOfDoSave = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoSave, methodDoSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoSave);
            var result2 = this.GetResultOfMethod<bool>(MethodDoSave, parametersOfDoSave, methodDoSaveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoSave.ShouldBeNull();
            methodDoSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoSave) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSave_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSave);
            Type [] methodDoSaveParametersTypes = null;
            object[] parametersOfDoSave = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoSave, methodDoSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoSave);
            var result2 = this.GetResultOfMethod<bool>(MethodDoSave, parametersOfDoSave, methodDoSaveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoSave.ShouldBeNull();
            methodDoSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoSave) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSave_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSave);
            Type [] methodDoSaveParametersTypes = null;
            object[] parametersOfDoSave = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoSave, parametersOfDoSave, methodDoSaveParametersTypes);

            // Assert
            parametersOfDoSave.ShouldBeNull();
            methodDoSaveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoSave) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSave_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSave);
            Type [] methodDoSaveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoSave, methodDoSaveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoSave) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSave_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSave);
            var currentMethodInfo = this.GetMethodInfo(MethodDoSave, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoDelete) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoDelete_Method_Call_Internally(Type[] types)
        {
            var methodDoDeleteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoDelete, methodDoDeleteParametersTypes);
        }

        #endregion

        #region Method Call : (DoDelete) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDelete_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDelete);
            Type [] methodDoDeleteParametersTypes = null;
            object[] parametersOfDoDelete = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoDelete, methodDoDeleteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoDelete);
            var result2 = this.GetResultOfMethod<bool>(MethodDoDelete, parametersOfDoDelete, methodDoDeleteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoDelete.ShouldBeNull();
            methodDoDeleteParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoDelete) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDelete_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDelete);
            Type [] methodDoDeleteParametersTypes = null;
            object[] parametersOfDoDelete = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoDelete, methodDoDeleteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoDelete);
            var result2 = this.GetResultOfMethod<bool>(MethodDoDelete, parametersOfDoDelete, methodDoDeleteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoDelete.ShouldBeNull();
            methodDoDeleteParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoDelete) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDelete_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDelete);
            Type [] methodDoDeleteParametersTypes = null;
            object[] parametersOfDoDelete = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoDelete, parametersOfDoDelete, methodDoDeleteParametersTypes);

            // Assert
            parametersOfDoDelete.ShouldBeNull();
            methodDoDeleteParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoDelete) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDelete_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDelete);
            Type [] methodDoDeleteParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoDelete, methodDoDeleteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoDeleteParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoDelete) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDelete_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDelete);
            var currentMethodInfo = this.GetMethodInfo(MethodDoDelete, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoSaveCollection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoSaveCollection_Method_Call_Internally(Type[] types)
        {
            var methodDoSaveCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoSaveCollection, methodDoSaveCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (DoSaveCollection) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSaveCollection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSaveCollection);
            var ReplaceAll = this.CreateType<bool>();
            var methodDoSaveCollectionParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfDoSaveCollection = { ReplaceAll };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoSaveCollection, methodDoSaveCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoSaveCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodDoSaveCollection, parametersOfDoSaveCollection, methodDoSaveCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoSaveCollection.ShouldNotBeNull();
            parametersOfDoSaveCollection.Length.ShouldBe(1);
            methodDoSaveCollectionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoSaveCollection) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSaveCollection_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSaveCollection);
            var ReplaceAll = this.CreateType<bool>();
            var methodDoSaveCollectionParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfDoSaveCollection = { ReplaceAll };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoSaveCollection, methodDoSaveCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoSaveCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodDoSaveCollection, parametersOfDoSaveCollection, methodDoSaveCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoSaveCollection.ShouldNotBeNull();
            parametersOfDoSaveCollection.Length.ShouldBe(1);
            methodDoSaveCollectionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoSaveCollection) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSaveCollection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSaveCollection);
            var ReplaceAll = this.CreateType<bool>();
            var methodDoSaveCollectionParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfDoSaveCollection = { ReplaceAll };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoSaveCollection, parametersOfDoSaveCollection, methodDoSaveCollectionParametersTypes);

            // Assert
            parametersOfDoSaveCollection.ShouldNotBeNull();
            parametersOfDoSaveCollection.Length.ShouldBe(1);
            methodDoSaveCollectionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoSaveCollection) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSaveCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSaveCollection);
            var methodDoSaveCollectionParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoSaveCollection, methodDoSaveCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoSaveCollectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoSaveCollection) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSaveCollection_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSaveCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodDoSaveCollection, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoSaveCollection) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoSaveCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSaveCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodDoSaveCollection, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoRetrieve) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoRetrieve_Method_Call_Internally(Type[] types)
        {
            var methodDoRetrieveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoRetrieve, methodDoRetrieveParametersTypes);
        }

        #endregion

        #region Method Call : (DoRetrieve) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieve_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieve);
            Type [] methodDoRetrieveParametersTypes = null;
            object[] parametersOfDoRetrieve = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieve, methodDoRetrieveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoRetrieve);
            var result2 = this.GetResultOfMethod<bool>(MethodDoRetrieve, parametersOfDoRetrieve, methodDoRetrieveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoRetrieve.ShouldBeNull();
            methodDoRetrieveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieve) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieve_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieve);
            Type [] methodDoRetrieveParametersTypes = null;
            object[] parametersOfDoRetrieve = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieve, methodDoRetrieveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoRetrieve);
            var result2 = this.GetResultOfMethod<bool>(MethodDoRetrieve, parametersOfDoRetrieve, methodDoRetrieveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoRetrieve.ShouldBeNull();
            methodDoRetrieveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieve) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieve_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieve);
            Type [] methodDoRetrieveParametersTypes = null;
            object[] parametersOfDoRetrieve = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoRetrieve, parametersOfDoRetrieve, methodDoRetrieveParametersTypes);

            // Assert
            parametersOfDoRetrieve.ShouldBeNull();
            methodDoRetrieveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoRetrieve) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieve_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieve);
            Type [] methodDoRetrieveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoRetrieve, methodDoRetrieveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoRetrieveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieve) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieve_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieve);
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieve, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieveCollection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoRetrieveCollection_Method_Call_Internally(Type[] types)
        {
            var methodDoRetrieveCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoRetrieveCollection, methodDoRetrieveCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (DoRetrieveCollection) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveCollection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveCollection);
            var Partial = this.CreateType<bool>();
            var ForceRuntime = this.CreateType<bool>();
            var LoadFullBO = this.CreateType<bool>();
            var methodDoRetrieveCollectionParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(bool) };
            object[] parametersOfDoRetrieveCollection = { Partial, ForceRuntime, LoadFullBO };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieveCollection, methodDoRetrieveCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoRetrieveCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodDoRetrieveCollection, parametersOfDoRetrieveCollection, methodDoRetrieveCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoRetrieveCollection.ShouldNotBeNull();
            parametersOfDoRetrieveCollection.Length.ShouldBe(3);
            methodDoRetrieveCollectionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoRetrieveCollection) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveCollection_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveCollection);
            var Partial = this.CreateType<bool>();
            var ForceRuntime = this.CreateType<bool>();
            var LoadFullBO = this.CreateType<bool>();
            var methodDoRetrieveCollectionParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(bool) };
            object[] parametersOfDoRetrieveCollection = { Partial, ForceRuntime, LoadFullBO };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieveCollection, methodDoRetrieveCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoRetrieveCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodDoRetrieveCollection, parametersOfDoRetrieveCollection, methodDoRetrieveCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoRetrieveCollection.ShouldNotBeNull();
            parametersOfDoRetrieveCollection.Length.ShouldBe(3);
            methodDoRetrieveCollectionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoRetrieveCollection) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveCollection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveCollection);
            var Partial = this.CreateType<bool>();
            var ForceRuntime = this.CreateType<bool>();
            var LoadFullBO = this.CreateType<bool>();
            var methodDoRetrieveCollectionParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(bool) };
            object[] parametersOfDoRetrieveCollection = { Partial, ForceRuntime, LoadFullBO };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoRetrieveCollection, parametersOfDoRetrieveCollection, methodDoRetrieveCollectionParametersTypes);

            // Assert
            parametersOfDoRetrieveCollection.ShouldNotBeNull();
            parametersOfDoRetrieveCollection.Length.ShouldBe(3);
            methodDoRetrieveCollectionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoRetrieveCollection) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveCollection);
            var methodDoRetrieveCollectionParametersTypes = new Type[] { typeof(bool), typeof(bool), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoRetrieveCollection, methodDoRetrieveCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoRetrieveCollectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoRetrieveCollection) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveCollection_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieveCollection, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieveCollection) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieveCollection, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoDeleteAll) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoDeleteAll_Method_Call_Internally(Type[] types)
        {
            var methodDoDeleteAllParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoDeleteAll, methodDoDeleteAllParametersTypes);
        }

        #endregion

        #region Method Call : (DoDeleteAll) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDeleteAll_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDeleteAll);
            Type [] methodDoDeleteAllParametersTypes = null;
            object[] parametersOfDoDeleteAll = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoDeleteAll, methodDoDeleteAllParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoDeleteAll);
            var result2 = this.GetResultOfMethod<bool>(MethodDoDeleteAll, parametersOfDoDeleteAll, methodDoDeleteAllParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoDeleteAll.ShouldBeNull();
            methodDoDeleteAllParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoDeleteAll) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDeleteAll_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDeleteAll);
            Type [] methodDoDeleteAllParametersTypes = null;
            object[] parametersOfDoDeleteAll = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoDeleteAll, methodDoDeleteAllParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoDeleteAll);
            var result2 = this.GetResultOfMethod<bool>(MethodDoDeleteAll, parametersOfDoDeleteAll, methodDoDeleteAllParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoDeleteAll.ShouldBeNull();
            methodDoDeleteAllParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoDeleteAll) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDeleteAll_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDeleteAll);
            Type [] methodDoDeleteAllParametersTypes = null;
            object[] parametersOfDoDeleteAll = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoDeleteAll, parametersOfDoDeleteAll, methodDoDeleteAllParametersTypes);

            // Assert
            parametersOfDoDeleteAll.ShouldBeNull();
            methodDoDeleteAllParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoDeleteAll) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDeleteAll_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDeleteAll);
            Type [] methodDoDeleteAllParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoDeleteAll, methodDoDeleteAllParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoDeleteAllParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoDeleteAll) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoDeleteAll_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoDeleteAll);
            var currentMethodInfo = this.GetMethodInfo(MethodDoDeleteAll, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoValidateCollection) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoValidateCollection_Method_Call_Internally(Type[] types)
        {
            var methodDoValidateCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoValidateCollection, methodDoValidateCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (DoValidateCollection) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateCollection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateCollection);
            Type [] methodDoValidateCollectionParametersTypes = null;
            object[] parametersOfDoValidateCollection = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidateCollection, methodDoValidateCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoValidateCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodDoValidateCollection, parametersOfDoValidateCollection, methodDoValidateCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoValidateCollection.ShouldBeNull();
            methodDoValidateCollectionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoValidateCollection) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateCollection_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateCollection);
            Type [] methodDoValidateCollectionParametersTypes = null;
            object[] parametersOfDoValidateCollection = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidateCollection, methodDoValidateCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoValidateCollection);
            var result2 = this.GetResultOfMethod<bool>(MethodDoValidateCollection, parametersOfDoValidateCollection, methodDoValidateCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoValidateCollection.ShouldBeNull();
            methodDoValidateCollectionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoValidateCollection) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateCollection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateCollection);
            Type [] methodDoValidateCollectionParametersTypes = null;
            object[] parametersOfDoValidateCollection = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoValidateCollection, parametersOfDoValidateCollection, methodDoValidateCollectionParametersTypes);

            // Assert
            parametersOfDoValidateCollection.ShouldBeNull();
            methodDoValidateCollectionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoValidateCollection) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateCollection);
            Type [] methodDoValidateCollectionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoValidateCollection, methodDoValidateCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoValidateCollectionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoValidateCollection) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateCollection_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidateCollection, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetValidationStatus) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_SetValidationStatus_Method_Call_Internally(Type[] types)
        {
            var methodSetValidationStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetValidationStatus, methodSetValidationStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetValidationStatus) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_GetValidationStatus_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValidationStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetValidationStatus, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoValidateStore) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoValidateStore_Method_Call_Internally(Type[] types)
        {
            var methodDoValidateStoreParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoValidateStore, methodDoValidateStoreParametersTypes);
        }

        #endregion

        #region Method Call : (DoValidateStore) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateStore_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateStore);
            var SaveRuntime = this.CreateType<bool>();
            var methodDoValidateStoreParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfDoValidateStore = { SaveRuntime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidateStore, methodDoValidateStoreParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoValidateStore);
            var result2 = this.GetResultOfMethod<bool>(MethodDoValidateStore, parametersOfDoValidateStore, methodDoValidateStoreParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoValidateStore.ShouldNotBeNull();
            parametersOfDoValidateStore.Length.ShouldBe(1);
            methodDoValidateStoreParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoValidateStore) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateStore_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateStore);
            var SaveRuntime = this.CreateType<bool>();
            var methodDoValidateStoreParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfDoValidateStore = { SaveRuntime };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidateStore, methodDoValidateStoreParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoValidateStore);
            var result2 = this.GetResultOfMethod<bool>(MethodDoValidateStore, parametersOfDoValidateStore, methodDoValidateStoreParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoValidateStore.ShouldNotBeNull();
            parametersOfDoValidateStore.Length.ShouldBe(1);
            methodDoValidateStoreParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoValidateStore) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateStore_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateStore);
            var SaveRuntime = this.CreateType<bool>();
            var methodDoValidateStoreParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfDoValidateStore = { SaveRuntime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoValidateStore, parametersOfDoValidateStore, methodDoValidateStoreParametersTypes);

            // Assert
            parametersOfDoValidateStore.ShouldNotBeNull();
            parametersOfDoValidateStore.Length.ShouldBe(1);
            methodDoValidateStoreParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoValidateStore) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateStore_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateStore);
            var methodDoValidateStoreParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoValidateStore, methodDoValidateStoreParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoValidateStoreParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoValidateStore) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateStore_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateStore);
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidateStore, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoValidateStore) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoValidateStore_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidateStore);
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidateStore, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoPublishToDatabase) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoPublishToDatabase_Method_Call_Internally(Type[] types)
        {
            var methodDoPublishToDatabaseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoPublishToDatabase, methodDoPublishToDatabaseParametersTypes);
        }

        #endregion

        #region Method Call : (DoPublishToDatabase) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoPublishToDatabase_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoPublishToDatabase);
            Type [] methodDoPublishToDatabaseParametersTypes = null;
            object[] parametersOfDoPublishToDatabase = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoPublishToDatabase, methodDoPublishToDatabaseParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoPublishToDatabase);
            var result2 = this.GetResultOfMethod<bool>(MethodDoPublishToDatabase, parametersOfDoPublishToDatabase, methodDoPublishToDatabaseParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoPublishToDatabase.ShouldBeNull();
            methodDoPublishToDatabaseParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoPublishToDatabase) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoPublishToDatabase_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoPublishToDatabase);
            Type [] methodDoPublishToDatabaseParametersTypes = null;
            object[] parametersOfDoPublishToDatabase = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoPublishToDatabase, methodDoPublishToDatabaseParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoPublishToDatabase);
            var result2 = this.GetResultOfMethod<bool>(MethodDoPublishToDatabase, parametersOfDoPublishToDatabase, methodDoPublishToDatabaseParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoPublishToDatabase.ShouldBeNull();
            methodDoPublishToDatabaseParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoPublishToDatabase) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoPublishToDatabase_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoPublishToDatabase);
            Type [] methodDoPublishToDatabaseParametersTypes = null;
            object[] parametersOfDoPublishToDatabase = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoPublishToDatabase, parametersOfDoPublishToDatabase, methodDoPublishToDatabaseParametersTypes);

            // Assert
            parametersOfDoPublishToDatabase.ShouldBeNull();
            methodDoPublishToDatabaseParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoPublishToDatabase) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoPublishToDatabase_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoPublishToDatabase);
            Type [] methodDoPublishToDatabaseParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoPublishToDatabase, methodDoPublishToDatabaseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoPublishToDatabaseParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoPublishToDatabase) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoPublishToDatabase_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoPublishToDatabase);
            var currentMethodInfo = this.GetMethodInfo(MethodDoPublishToDatabase, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CleanUpDanglingPropertiesProcedureMap) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_CleanUpDanglingPropertiesProcedureMap_Method_Call_Internally(Type[] types)
        {
            var methodCleanUpDanglingPropertiesProcedureMapParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCleanUpDanglingPropertiesProcedureMap, methodCleanUpDanglingPropertiesProcedureMapParametersTypes);
        }

        #endregion

        #region Method Call : (CleanUpDanglingPropertiesProcedureMap) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CleanUpDanglingPropertiesProcedureMap_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCleanUpDanglingPropertiesProcedureMap);
            var currentMethodInfo = this.GetMethodInfo(MethodCleanUpDanglingPropertiesProcedureMap, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CleanUpDanglingPropertiesProcedureMap) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CleanUpDanglingPropertiesProcedureMap_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCleanUpDanglingPropertiesProcedureMap);
            var currentMethodInfo = this.GetMethodInfo(MethodCleanUpDanglingPropertiesProcedureMap, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CallAOEDCreation) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_CallAOEDCreation_Method_Call_Internally(Type[] types)
        {
            var methodCallAOEDCreationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCallAOEDCreation, methodCallAOEDCreationParametersTypes);
        }

        #endregion

        #region Method Call : (CallAOEDCreation) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallAOEDCreation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallAOEDCreation);
            Type [] methodCallAOEDCreationParametersTypes = null;
            object[] parametersOfCallAOEDCreation = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCallAOEDCreation, methodCallAOEDCreationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfCallAOEDCreation);
            var result2 = this.GetResultOfMethod<bool>(MethodCallAOEDCreation, parametersOfCallAOEDCreation, methodCallAOEDCreationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCallAOEDCreation.ShouldBeNull();
            methodCallAOEDCreationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CallAOEDCreation) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallAOEDCreation_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallAOEDCreation);
            Type [] methodCallAOEDCreationParametersTypes = null;
            object[] parametersOfCallAOEDCreation = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCallAOEDCreation, methodCallAOEDCreationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfCallAOEDCreation);
            var result2 = this.GetResultOfMethod<bool>(MethodCallAOEDCreation, parametersOfCallAOEDCreation, methodCallAOEDCreationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCallAOEDCreation.ShouldBeNull();
            methodCallAOEDCreationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CallAOEDCreation) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallAOEDCreation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallAOEDCreation);
            Type [] methodCallAOEDCreationParametersTypes = null;
            object[] parametersOfCallAOEDCreation = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCallAOEDCreation, parametersOfCallAOEDCreation, methodCallAOEDCreationParametersTypes);

            // Assert
            parametersOfCallAOEDCreation.ShouldBeNull();
            methodCallAOEDCreationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallAOEDCreation) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallAOEDCreation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallAOEDCreation);
            Type [] methodCallAOEDCreationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCallAOEDCreation, methodCallAOEDCreationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCallAOEDCreationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CallAOEDCreation) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallAOEDCreation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallAOEDCreation);
            var currentMethodInfo = this.GetMethodInfo(MethodCallAOEDCreation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CallSQLGenCreation) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_CallSQLGenCreation_Method_Call_Internally(Type[] types)
        {
            var methodCallSQLGenCreationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCallSQLGenCreation, methodCallSQLGenCreationParametersTypes);
        }

        #endregion

        #region Method Call : (CallSQLGenCreation) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallSQLGenCreation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallSQLGenCreation);
            Type [] methodCallSQLGenCreationParametersTypes = null;
            object[] parametersOfCallSQLGenCreation = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCallSQLGenCreation, methodCallSQLGenCreationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfCallSQLGenCreation);
            var result2 = this.GetResultOfMethod<bool>(MethodCallSQLGenCreation, parametersOfCallSQLGenCreation, methodCallSQLGenCreationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCallSQLGenCreation.ShouldBeNull();
            methodCallSQLGenCreationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CallSQLGenCreation) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallSQLGenCreation_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallSQLGenCreation);
            Type [] methodCallSQLGenCreationParametersTypes = null;
            object[] parametersOfCallSQLGenCreation = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCallSQLGenCreation, methodCallSQLGenCreationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfCallSQLGenCreation);
            var result2 = this.GetResultOfMethod<bool>(MethodCallSQLGenCreation, parametersOfCallSQLGenCreation, methodCallSQLGenCreationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCallSQLGenCreation.ShouldBeNull();
            methodCallSQLGenCreationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CallSQLGenCreation) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallSQLGenCreation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallSQLGenCreation);
            Type [] methodCallSQLGenCreationParametersTypes = null;
            object[] parametersOfCallSQLGenCreation = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCallSQLGenCreation, parametersOfCallSQLGenCreation, methodCallSQLGenCreationParametersTypes);

            // Assert
            parametersOfCallSQLGenCreation.ShouldBeNull();
            methodCallSQLGenCreationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallSQLGenCreation) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallSQLGenCreation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallSQLGenCreation);
            Type [] methodCallSQLGenCreationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCallSQLGenCreation, methodCallSQLGenCreationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCallSQLGenCreationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CallSQLGenCreation) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_CallSQLGenCreation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallSQLGenCreation);
            var currentMethodInfo = this.GetMethodInfo(MethodCallSQLGenCreation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieveEnums) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_DoRetrieveEnums_Method_Call_Internally(Type[] types)
        {
            var methodDoRetrieveEnumsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoRetrieveEnums, methodDoRetrieveEnumsParametersTypes);
        }

        #endregion

        #region Method Call : (DoRetrieveEnums) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveEnums_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveEnums);
            Type [] methodDoRetrieveEnumsParametersTypes = null;
            object[] parametersOfDoRetrieveEnums = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieveEnums, methodDoRetrieveEnumsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfDoRetrieveEnums);
            var result2 = this.GetResultOfMethod<bool>(MethodDoRetrieveEnums, parametersOfDoRetrieveEnums, methodDoRetrieveEnumsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoRetrieveEnums.ShouldBeNull();
            methodDoRetrieveEnumsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieveEnums) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveEnums_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveEnums);
            Type [] methodDoRetrieveEnumsParametersTypes = null;
            object[] parametersOfDoRetrieveEnums = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieveEnums, methodDoRetrieveEnumsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfDoRetrieveEnums);
            var result2 = this.GetResultOfMethod<bool>(MethodDoRetrieveEnums, parametersOfDoRetrieveEnums, methodDoRetrieveEnumsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDoRetrieveEnums.ShouldBeNull();
            methodDoRetrieveEnumsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieveEnums) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveEnums_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveEnums);
            Type [] methodDoRetrieveEnumsParametersTypes = null;
            object[] parametersOfDoRetrieveEnums = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDoRetrieveEnums, parametersOfDoRetrieveEnums, methodDoRetrieveEnumsParametersTypes);

            // Assert
            parametersOfDoRetrieveEnums.ShouldBeNull();
            methodDoRetrieveEnumsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoRetrieveEnums) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveEnums_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveEnums);
            Type [] methodDoRetrieveEnumsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoRetrieveEnums, methodDoRetrieveEnumsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoRetrieveEnumsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRetrieveEnums) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_DoRetrieveEnums_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRetrieveEnums);
            var currentMethodInfo = this.GetMethodInfo(MethodDoRetrieveEnums, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_objectEqualsNull_Static_Method_Call_Internally(Type[] types)
        {
            var methodobjectEqualsNullParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodobjectEqualsNull, methodobjectEqualsNullParametersTypes);
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var a = this.CreateType<object>();
            var b = this.CreateType<object>();

            // Act
            Action executeAction = () => Dictionary.objectEqualsNull(a, b);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var a = this.CreateType<object>();
            var b = this.CreateType<object>();
            var methodobjectEqualsNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfobjectEqualsNull = { a, b };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodobjectEqualsNull, methodobjectEqualsNullParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodobjectEqualsNull, methodobjectEqualsNullParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodobjectEqualsNull, parametersOfobjectEqualsNull, methodobjectEqualsNullParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfobjectEqualsNull.ShouldNotBeNull();
            parametersOfobjectEqualsNull.Length.ShouldBe(2);
            methodobjectEqualsNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodobjectEqualsNull, parametersOfobjectEqualsNull, methodobjectEqualsNullParametersTypes));
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var a = this.CreateType<object>();
            var b = this.CreateType<object>();
            var methodobjectEqualsNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfobjectEqualsNull = { a, b };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodobjectEqualsNull, methodobjectEqualsNullParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dictionaryInstanceFixture, parametersOfobjectEqualsNull);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfobjectEqualsNull.ShouldNotBeNull();
            parametersOfobjectEqualsNull.Length.ShouldBe(2);
            methodobjectEqualsNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var a = this.CreateType<object>();
            var b = this.CreateType<object>();
            var methodobjectEqualsNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfobjectEqualsNull = { a, b };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodobjectEqualsNull, parametersOfobjectEqualsNull, methodobjectEqualsNullParametersTypes);

            // Assert
            parametersOfobjectEqualsNull.ShouldNotBeNull();
            parametersOfobjectEqualsNull.Length.ShouldBe(2);
            methodobjectEqualsNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var methodobjectEqualsNullParametersTypes = new Type[] { typeof(object), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodobjectEqualsNull, methodobjectEqualsNullParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodobjectEqualsNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var methodobjectEqualsNullParametersTypes = new Type[] { typeof(object), typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodobjectEqualsNull, methodobjectEqualsNullParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodobjectEqualsNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var methodobjectEqualsNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodobjectEqualsNull, methodobjectEqualsNullParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodobjectEqualsNullParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var currentMethodInfo = this.GetMethodInfo(MethodobjectEqualsNull, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (objectEqualsNull) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_objectEqualsNull_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodobjectEqualsNull);
            var currentMethodInfo = this.GetMethodInfo(MethodobjectEqualsNull, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BooleansEqualWithNull) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Dictionary_BooleansEqualWithNull_Method_Call_Internally(Type[] types)
        {
            var methodBooleansEqualWithNullParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBooleansEqualWithNull, methodBooleansEqualWithNullParametersTypes);
        }

        #endregion

        #region Method Call : (BooleansEqualWithNull) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BooleansEqualWithNull_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBooleansEqualWithNull);
            var Value1 = this.CreateType<object>();
            var Value2 = this.CreateType<object>();
            var methodBooleansEqualWithNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfBooleansEqualWithNull = { Value1, Value2 };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBooleansEqualWithNull, methodBooleansEqualWithNullParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, parametersOfBooleansEqualWithNull);
            var result2 = this.GetResultOfMethod<bool>(MethodBooleansEqualWithNull, parametersOfBooleansEqualWithNull, methodBooleansEqualWithNullParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBooleansEqualWithNull.ShouldNotBeNull();
            parametersOfBooleansEqualWithNull.Length.ShouldBe(2);
            methodBooleansEqualWithNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (BooleansEqualWithNull) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BooleansEqualWithNull_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBooleansEqualWithNull);
            var Value1 = this.CreateType<object>();
            var Value2 = this.CreateType<object>();
            var methodBooleansEqualWithNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfBooleansEqualWithNull = { Value1, Value2 };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodBooleansEqualWithNull, methodBooleansEqualWithNullParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dictionaryInstanceFixture, out exception1, parametersOfBooleansEqualWithNull);
            var result2 = this.GetResultOfMethod<bool>(MethodBooleansEqualWithNull, parametersOfBooleansEqualWithNull, methodBooleansEqualWithNullParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBooleansEqualWithNull.ShouldNotBeNull();
            parametersOfBooleansEqualWithNull.Length.ShouldBe(2);
            methodBooleansEqualWithNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (BooleansEqualWithNull) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BooleansEqualWithNull_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBooleansEqualWithNull);
            var Value1 = this.CreateType<object>();
            var Value2 = this.CreateType<object>();
            var methodBooleansEqualWithNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            object[] parametersOfBooleansEqualWithNull = { Value1, Value2 };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodBooleansEqualWithNull, parametersOfBooleansEqualWithNull, methodBooleansEqualWithNullParametersTypes);

            // Assert
            parametersOfBooleansEqualWithNull.ShouldNotBeNull();
            parametersOfBooleansEqualWithNull.Length.ShouldBe(2);
            methodBooleansEqualWithNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BooleansEqualWithNull) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BooleansEqualWithNull_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBooleansEqualWithNull);
            var methodBooleansEqualWithNullParametersTypes = new Type[] { typeof(object), typeof(object) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBooleansEqualWithNull, methodBooleansEqualWithNullParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBooleansEqualWithNullParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BooleansEqualWithNull) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Dictionary_BooleansEqualWithNull_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBooleansEqualWithNull);
            var currentMethodInfo = this.GetMethodInfo(MethodBooleansEqualWithNull, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}