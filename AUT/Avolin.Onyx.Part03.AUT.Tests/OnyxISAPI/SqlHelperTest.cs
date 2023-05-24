using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using OnyxISAPI.Model;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.SqlHelper" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SqlHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SqlHelper" />)
        /// </summary>
        public SqlHelperTest() : base(typeof(SqlHelper))
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

        #region General Initializer : Class (SqlHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _sqlHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="SqlHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _sqlHelperInstanceType = typeof(SqlHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SqlHelper) Initializer

        #region Properties

        private const string PropertySQLResource = "SQLResource";

        #endregion

        #region Methods

        private const string MethodGetSqlStatement = "GetSqlStatement";
        private const string MethodVerifySystemMaxRecordLimit = "VerifySystemMaxRecordLimit";
        private const string MethodConstructWhereClause = "ConstructWhereClause";
        private const string MethodConstructCondition = "ConstructCondition";
        private const string MethodJoinMultipleValues = "JoinMultipleValues";
        private const string MethodGetOperatorType = "GetOperatorType";
        private const string MethodFormatMultipleValues = "FormatMultipleValues";
        private const string MethodPreProcessParameters = "PreProcessParameters";
        private const string MethodGetFieldType = "GetFieldType";
        private const string MethodPreProcessDateOperator = "PreProcessDateOperator";
        private const string MethodApplyTimeZoneDifference = "ApplyTimeZoneDifference";
        private const string MethodGetSystemParameterValue = "GetSystemParameterValue";
        private const string MethodGetDateRange = "GetDateRange";
        private const string MethodGetFirstDayOfWeek = "GetFirstDayOfWeek";
        private const string MethodGetFirstDayOfMonth = "GetFirstDayOfMonth";
        private const string MethodGetFirstDayOfQuarter = "GetFirstDayOfQuarter";
        private const string MethodGetFirstDayOfYear = "GetFirstDayOfYear";
        private const string MethodConvertToGmtDateTime = "ConvertToGmtDateTime";
        private const string MethodCheckSystemMaxRecordLimit = "CheckSystemMaxRecordLimit";
        private const string MethodIsExistsCondition = "IsExistsCondition";
        private const string MethodConstructORCodintions = "ConstructORCodintions";
        private const string MethodGetSQLInjectionSafeSting = "GetSQLInjectionSafeSting";
        private const string MethodCreateSearchLBOParameter = "CreateSearchLBOParameter";
        
        private const string MethodFormatMultipleValuesForProcudure = "FormatMultipleValuesForProcudure";
        private const string MethodConstructORCodintionsForProcudure = "ConstructORCodintionsForProcudure";

        #endregion

        #region Fields

        private const string FieldSQL_GET_ENTITIES = "SQL_GET_ENTITIES";
        private const string FieldSQL_GET_COMPANY_TYPES = "SQL_GET_COMPANY_TYPES";
        private const string FieldSQL_GET_COMPANY_SUBTYPES = "SQL_GET_COMPANY_SUBTYPES";
        private const string FieldSQL_GET_COMPANY_STATUS_LISTS = "SQL_GET_COMPANY_STATUS_LISTS";
        private const string FieldSQL_GET_COMPANY_COUNTRIES = "SQL_GET_COMPANY_COUNTRIES";
        private const string FieldSQL_GET_COMPANY_STATES = "SQL_GET_COMPANY_STATES";
        private const string FieldSQL_GET_COMPANY_MARKET_SECTOR = "SQL_GET_COMPANY_MARKET_SECTOR";
        private const string FieldSQL_GET_COMPANY_INTERNAL_CONTACTS = "SQL_GET_COMPANY_INTERNAL_CONTACTS";
        private const string FieldSQL_GET_COUNTRIES = "SQL_GET_COUNTRIES";
        private const string FieldSQL_GET_STATES = "SQL_GET_STATES";
        private const string FieldSQL_GET_MARKET_SECTOR = "SQL_GET_MARKET_SECTOR";
        private const string FieldSQL_GET_INDIVIDUAL_INTERNAL_CONTACTS = "SQL_GET_INDIVIDUAL_INTERNAL_CONTACTS";
        private const string FieldSQL_GET_INDIVIDUAL_TYPES = "SQL_GET_INDIVIDUAL_TYPES";
        private const string FieldSQL_GET_INDIVIDUAL_SUBTYPES = "SQL_GET_INDIVIDUAL_SUBTYPES";
        private const string FieldSQL_GET_INDIVIDUAL_STATUS = "SQL_GET_INDIVIDUAL_STATUS";
        private const string FieldSQL_GET_INDIVIDUAL_COUNTRY = "SQL_GET_INDIVIDUAL_COUNTRY";
        private const string FieldSQL_GET_INDIVIDUAL_STATE = "SQL_GET_INDIVIDUAL_STATE";
        private const string FieldSQL_GET_SALES_OPPORTUNITY_ASSIGNEES = "SQL_GET_SALES_OPPORTUNITY_ASSIGNEES";
        private const string FieldSQL_GET_SALES_OPPORTUNITY_STATUS_LIST = "SQL_GET_SALES_OPPORTUNITY_STATUS_LIST";
        private const string FieldSQL_GET_SALES_OPPORTUNITY_CUSTOMER_NAMES = "SQL_GET_SALES_OPPORTUNITY_CUSTOMER_NAMES";
        private const string FieldSQL_GET_SALES_OPPORTUNITY_PRIORITY_LIST = "SQL_GET_SALES_OPPORTUNITY_PRIORITY_LIST";
        private const string FieldSQL_GET_SALES_OPPORTUNITY_PRODUCT_LIST = "SQL_GET_SALES_OPPORTUNITY_PRODUCT_LIST";
        private const string FieldSQL_GET_SERVICE_REQUEST_ASSIGNEES = "SQL_GET_SERVICE_REQUEST_ASSIGNEES";
        private const string FieldSQL_GET_SERVICE_REQUEST_STATUS_LIST = "SQL_GET_SERVICE_REQUEST_STATUS_LIST";
        private const string FieldSQL_GET_SERVICE_REQUEST_PRIORITY_LIST = "SQL_GET_SERVICE_REQUEST_PRIORITY_LIST";
        private const string FieldSQL_GET_SERVICE_REQUEST_PRODUCT_LIST = "SQL_GET_SERVICE_REQUEST_PRODUCT_LIST";
        private const string FieldSQL_GET_SERVICE_REQUEST_CUSTOMER_NAMES = "SQL_GET_SERVICE_REQUEST_CUSTOMER_NAMES";
        private const string FieldSQL_GET_SUPPORT_INCIDENT_ASSIGNEES = "SQL_GET_SUPPORT_INCIDENT_ASSIGNEES";
        private const string FieldSQL_GET_SUPPORT_INCIDENT_STATUS_LIST = "SQL_GET_SUPPORT_INCIDENT_STATUS_LIST";
        private const string FieldSQL_GET_SUPPORT_INCIDENT_PRIORITY_LIST = "SQL_GET_SUPPORT_INCIDENT_PRIORITY_LIST";
        private const string FieldSQL_GET_SUPPORT_INCIDENT_PRODUCT_LIST = "SQL_GET_SUPPORT_INCIDENT_PRODUCT_LIST";
        private const string FieldSQL_GET_SUPPORT_INCIDENT_CUSTOMER_NAMES = "SQL_GET_SUPPORT_INCIDENT_CUSTOMER_NAMES";
        private const string FieldSQL_GET_WORKTICKET_TYPES = "SQL_GET_WORKTICKET_TYPES";
        private const string FieldSQL_GET_WORKTICKET_PRODUCTS = "SQL_GET_WORKTICKET_PRODUCTS";
        private const string FieldSQL_GET_WORKTICKET_STATUS_LIST = "SQL_GET_WORKTICKET_STATUS_LIST";
        private const string FieldSQL_GET_WORKTICKET_VERSION_FOUND_LIST = "SQL_GET_WORKTICKET_VERSION_FOUND_LIST";
        private const string FieldSQL_GET_WORKTICKET_VERSION_FIXED_LIST = "SQL_GET_WORKTICKET_VERSION_FIXED_LIST";
        private const string FieldSQL_GET_TASK_ASSIGNEES = "SQL_GET_TASK_ASSIGNEES";
        private const string FieldSQL_GET_TASK_CATEGORY = "SQL_GET_TASK_CATEGORY";
        private const string FieldSQL_GET_TASK_TYPES = "SQL_GET_TASK_TYPES";
        private const string FieldSQL_GET_TASK_STATUS_LIST = "SQL_GET_TASK_STATUS_LIST";
        private const string FieldSQL_GET_TASK_PRIORITY_LIST = "SQL_GET_TASK_PRIORITY_LIST";
        private const string FieldSQL_GET_TASK_CUSTOMER_LIST = "SQL_GET_TASK_CUSTOMER_LIST";
        private const string FieldSQL_GET_FORECAST_ASSIGNEES = "SQL_GET_FORECAST_ASSIGNEES";
        private const string FieldSQL_GET_FORECAST_STATUS_LIST = "SQL_GET_FORECAST_STATUS_LIST";
        private const string FieldSQL_GET_FORECAST_CUSTOMER_LIST = "SQL_GET_FORECAST_CUSTOMER_LIST";
        private const string FieldSQL_RESOURCE_FILE = "SQL_RESOURCE_FILE";

        #endregion

        #endregion

        #region General Initializer : Class (SqlHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SqlHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SqlHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SqlHelper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SqlHelper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SqlHelper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SqlHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SqlHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SqlHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SqlHelper)

        #region General Initializer : Class (SqlHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SqlHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSqlStatement, 0)]
        [TestCase(MethodVerifySystemMaxRecordLimit, 0)]
        [TestCase(MethodGetSqlStatement, 1)]
        [TestCase(MethodConstructWhereClause, 0)]
        [TestCase(MethodConstructCondition, 0)]
        [TestCase(MethodConstructCondition, 1)]
        [TestCase(MethodGetOperatorType, 0)]
        [TestCase(MethodFormatMultipleValues, 0)]
        [TestCase(MethodPreProcessParameters, 0)]
        [TestCase(MethodGetFieldType, 0)]
        [TestCase(MethodPreProcessDateOperator, 0)]
        [TestCase(MethodApplyTimeZoneDifference, 0)]
        [TestCase(MethodGetSystemParameterValue, 0)]
        [TestCase(MethodGetDateRange, 0)]
        [TestCase(MethodGetFirstDayOfWeek, 0)]
        [TestCase(MethodGetFirstDayOfMonth, 0)]
        [TestCase(MethodGetFirstDayOfQuarter, 0)]
        [TestCase(MethodGetFirstDayOfYear, 0)]
        [TestCase(MethodConvertToGmtDateTime, 0)]
        [TestCase(MethodConvertToGmtDateTime, 1)]
        [TestCase(MethodConvertToGmtDateTime, 2)]
        [TestCase(MethodCheckSystemMaxRecordLimit, 0)]
        [TestCase(MethodIsExistsCondition, 0)]
        [TestCase(MethodConstructORCodintions, 0)]
        [TestCase(MethodGetSQLInjectionSafeSting, 0)]
        [TestCase(MethodCreateSearchLBOParameter, 0)]
        [TestCase(MethodFormatMultipleValuesForProcudure, 0)]
        [TestCase(MethodConstructORCodintionsForProcudure, 0)]
        public void AUT_SqlHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SqlHelper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SqlHelper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySQLResource)]
        [Category("AUT Property")]
        public void AUT_SqlHelper_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (SqlHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SqlHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldSQL_GET_ENTITIES)]
        [TestCase(FieldSQL_GET_COMPANY_TYPES)]
        [TestCase(FieldSQL_GET_COMPANY_SUBTYPES)]
        [TestCase(FieldSQL_GET_COMPANY_STATUS_LISTS)]
        [TestCase(FieldSQL_GET_COMPANY_COUNTRIES)]
        [TestCase(FieldSQL_GET_COMPANY_STATES)]
        [TestCase(FieldSQL_GET_COMPANY_MARKET_SECTOR)]
        [TestCase(FieldSQL_GET_COMPANY_INTERNAL_CONTACTS)]
        [TestCase(FieldSQL_GET_COUNTRIES)]
        [TestCase(FieldSQL_GET_STATES)]
        [TestCase(FieldSQL_GET_MARKET_SECTOR)]
        [TestCase(FieldSQL_GET_INDIVIDUAL_INTERNAL_CONTACTS)]
        [TestCase(FieldSQL_GET_INDIVIDUAL_TYPES)]
        [TestCase(FieldSQL_GET_INDIVIDUAL_SUBTYPES)]
        [TestCase(FieldSQL_GET_INDIVIDUAL_STATUS)]
        [TestCase(FieldSQL_GET_INDIVIDUAL_COUNTRY)]
        [TestCase(FieldSQL_GET_INDIVIDUAL_STATE)]
        [TestCase(FieldSQL_GET_SALES_OPPORTUNITY_ASSIGNEES)]
        [TestCase(FieldSQL_GET_SALES_OPPORTUNITY_STATUS_LIST)]
        [TestCase(FieldSQL_GET_SALES_OPPORTUNITY_CUSTOMER_NAMES)]
        [TestCase(FieldSQL_GET_SALES_OPPORTUNITY_PRIORITY_LIST)]
        [TestCase(FieldSQL_GET_SALES_OPPORTUNITY_PRODUCT_LIST)]
        [TestCase(FieldSQL_GET_SERVICE_REQUEST_ASSIGNEES)]
        [TestCase(FieldSQL_GET_SERVICE_REQUEST_STATUS_LIST)]
        [TestCase(FieldSQL_GET_SERVICE_REQUEST_PRIORITY_LIST)]
        [TestCase(FieldSQL_GET_SERVICE_REQUEST_PRODUCT_LIST)]
        [TestCase(FieldSQL_GET_SERVICE_REQUEST_CUSTOMER_NAMES)]
        [TestCase(FieldSQL_GET_SUPPORT_INCIDENT_ASSIGNEES)]
        [TestCase(FieldSQL_GET_SUPPORT_INCIDENT_STATUS_LIST)]
        [TestCase(FieldSQL_GET_SUPPORT_INCIDENT_PRIORITY_LIST)]
        [TestCase(FieldSQL_GET_SUPPORT_INCIDENT_PRODUCT_LIST)]
        [TestCase(FieldSQL_GET_SUPPORT_INCIDENT_CUSTOMER_NAMES)]
        [TestCase(FieldSQL_GET_WORKTICKET_TYPES)]
        [TestCase(FieldSQL_GET_WORKTICKET_PRODUCTS)]
        [TestCase(FieldSQL_GET_WORKTICKET_STATUS_LIST)]
        [TestCase(FieldSQL_GET_WORKTICKET_VERSION_FOUND_LIST)]
        [TestCase(FieldSQL_GET_WORKTICKET_VERSION_FIXED_LIST)]
        [TestCase(FieldSQL_GET_TASK_ASSIGNEES)]
        [TestCase(FieldSQL_GET_TASK_CATEGORY)]
        [TestCase(FieldSQL_GET_TASK_TYPES)]
        [TestCase(FieldSQL_GET_TASK_STATUS_LIST)]
        [TestCase(FieldSQL_GET_TASK_PRIORITY_LIST)]
        [TestCase(FieldSQL_GET_TASK_CUSTOMER_LIST)]
        [TestCase(FieldSQL_GET_FORECAST_ASSIGNEES)]
        [TestCase(FieldSQL_GET_FORECAST_STATUS_LIST)]
        [TestCase(FieldSQL_GET_FORECAST_CUSTOMER_LIST)]
        [TestCase(FieldSQL_RESOURCE_FILE)]
        [Category("AUT Fields")]
        public void AUT_SqlHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SqlHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SqlHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SqlHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _sqlHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSqlStatement) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSqlStatementParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSqlStatement, methodGetSqlStatementParametersTypes);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => SqlHelper.GetSqlStatement(key);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.GetSqlStatement(key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSqlStatement = { key };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSqlStatement, methodGetSqlStatementParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSqlStatement);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSqlStatement.ShouldNotBeNull();
            parametersOfGetSqlStatement.Length.ShouldBe(1);
            methodGetSqlStatementParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSqlStatement = { key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSqlStatement, parametersOfGetSqlStatement, methodGetSqlStatementParametersTypes);

            // Assert
            parametersOfGetSqlStatement.ShouldNotBeNull();
            parametersOfGetSqlStatement.Length.ShouldBe(1);
            methodGetSqlStatementParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSqlStatement, methodGetSqlStatementParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSqlStatementParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSqlStatement, methodGetSqlStatementParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSqlStatementParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSqlStatement, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSqlStatement, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (VerifySystemMaxRecordLimit) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_VerifySystemMaxRecordLimit_Static_Method_Call_Internally(Type[] types)
        {
            var methodVerifySystemMaxRecordLimitParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodVerifySystemMaxRecordLimit, methodVerifySystemMaxRecordLimitParametersTypes);
        }

        #endregion

        #region Method Call : (VerifySystemMaxRecordLimit) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_VerifySystemMaxRecordLimit_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodVerifySystemMaxRecordLimit);
            var entityConfiguration = this.CreateType<EntityConfiguration>();
            var operation = this.CreateType<NavigatorUiOperation>();

            // Act
            Action executeAction = () => SqlHelper.VerifySystemMaxRecordLimit(entityConfiguration, operation);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (VerifySystemMaxRecordLimit) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_VerifySystemMaxRecordLimit_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodVerifySystemMaxRecordLimit);
            var entityConfiguration = this.CreateType<EntityConfiguration>();
            var operation = this.CreateType<NavigatorUiOperation>();
            var methodVerifySystemMaxRecordLimitParametersTypes = new Type[] { typeof(EntityConfiguration), typeof(NavigatorUiOperation) };
            object[] parametersOfVerifySystemMaxRecordLimit = { entityConfiguration, operation };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodVerifySystemMaxRecordLimit, methodVerifySystemMaxRecordLimitParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfVerifySystemMaxRecordLimit);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfVerifySystemMaxRecordLimit.ShouldNotBeNull();
            parametersOfVerifySystemMaxRecordLimit.Length.ShouldBe(2);
            methodVerifySystemMaxRecordLimitParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (VerifySystemMaxRecordLimit) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_VerifySystemMaxRecordLimit_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodVerifySystemMaxRecordLimit);
            var entityConfiguration = this.CreateType<EntityConfiguration>();
            var operation = this.CreateType<NavigatorUiOperation>();
            var methodVerifySystemMaxRecordLimitParametersTypes = new Type[] { typeof(EntityConfiguration), typeof(NavigatorUiOperation) };
            object[] parametersOfVerifySystemMaxRecordLimit = { entityConfiguration, operation };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodVerifySystemMaxRecordLimit, parametersOfVerifySystemMaxRecordLimit, methodVerifySystemMaxRecordLimitParametersTypes);

            // Assert
            parametersOfVerifySystemMaxRecordLimit.ShouldNotBeNull();
            parametersOfVerifySystemMaxRecordLimit.Length.ShouldBe(2);
            methodVerifySystemMaxRecordLimitParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (VerifySystemMaxRecordLimit) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_VerifySystemMaxRecordLimit_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodVerifySystemMaxRecordLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodVerifySystemMaxRecordLimit, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (VerifySystemMaxRecordLimit) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_VerifySystemMaxRecordLimit_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodVerifySystemMaxRecordLimit);
            var methodVerifySystemMaxRecordLimitParametersTypes = new Type[] { typeof(EntityConfiguration), typeof(NavigatorUiOperation) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodVerifySystemMaxRecordLimit, methodVerifySystemMaxRecordLimitParametersTypes);

            // Assert
            methodVerifySystemMaxRecordLimitParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (VerifySystemMaxRecordLimit) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_VerifySystemMaxRecordLimit_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodVerifySystemMaxRecordLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodVerifySystemMaxRecordLimit, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetSqlStatement_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetSqlStatementParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSqlStatement, methodGetSqlStatementParametersTypes);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => SqlHelper.GetSqlStatement(key, navigatorEntity, parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.GetSqlStatement(key, navigatorEntity, parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfGetSqlStatement = { key, navigatorEntity, parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSqlStatement, methodGetSqlStatementParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetSqlStatement, methodGetSqlStatementParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetSqlStatement, parametersOfGetSqlStatement, methodGetSqlStatementParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSqlStatement);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSqlStatement.ShouldNotBeNull();
            parametersOfGetSqlStatement.Length.ShouldBe(3);
            methodGetSqlStatementParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfGetSqlStatement = { key, navigatorEntity, parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSqlStatement, parametersOfGetSqlStatement, methodGetSqlStatementParametersTypes);

            // Assert
            parametersOfGetSqlStatement.ShouldNotBeNull();
            parametersOfGetSqlStatement.Length.ShouldBe(3);
            methodGetSqlStatementParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSqlStatement, methodGetSqlStatementParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSqlStatementParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var methodGetSqlStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSqlStatement, methodGetSqlStatementParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSqlStatementParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSqlStatement, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSqlStatement_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSqlStatement, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConstructWhereClause_Static_Method_Call_Internally(Type[] types)
        {
            var methodConstructWhereClauseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructWhereClause, methodConstructWhereClauseParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var parameterCollections = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => SqlHelper.ConstructWhereClause(parameterCollections, navigatorEntity, parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var parameterCollections = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.ConstructWhereClause(parameterCollections, navigatorEntity, parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var parameterCollections = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodConstructWhereClauseParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfConstructWhereClause = { parameterCollections, navigatorEntity, parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructWhereClause, methodConstructWhereClauseParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConstructWhereClause, methodConstructWhereClauseParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConstructWhereClause, parametersOfConstructWhereClause, methodConstructWhereClauseParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConstructWhereClause);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConstructWhereClause.ShouldNotBeNull();
            parametersOfConstructWhereClause.Length.ShouldBe(3);
            methodConstructWhereClauseParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var parameterCollections = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodConstructWhereClauseParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfConstructWhereClause = { parameterCollections, navigatorEntity, parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructWhereClause, parametersOfConstructWhereClause, methodConstructWhereClauseParametersTypes);

            // Assert
            parametersOfConstructWhereClause.ShouldNotBeNull();
            parametersOfConstructWhereClause.Length.ShouldBe(3);
            methodConstructWhereClauseParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var methodConstructWhereClauseParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructWhereClause, methodConstructWhereClauseParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConstructWhereClauseParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var methodConstructWhereClauseParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructWhereClause, methodConstructWhereClauseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructWhereClauseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructWhereClause, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructWhereClause) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructWhereClause_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructWhereClause);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructWhereClause, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Internally(Type[] types)
        {
            var methodConstructConditionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var condition = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => SqlHelper.ConstructCondition(condition, navigatorEntity, parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var condition = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.ConstructCondition(condition, navigatorEntity, parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var condition = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfConstructCondition = { condition, navigatorEntity, parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructCondition, methodConstructConditionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConstructCondition, parametersOfConstructCondition, methodConstructConditionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConstructCondition);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConstructCondition.ShouldNotBeNull();
            parametersOfConstructCondition.Length.ShouldBe(3);
            methodConstructConditionParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var condition = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfConstructCondition = { condition, navigatorEntity, parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructCondition, parametersOfConstructCondition, methodConstructConditionParametersTypes);

            // Assert
            parametersOfConstructCondition.ShouldNotBeNull();
            parametersOfConstructCondition.Length.ShouldBe(3);
            methodConstructConditionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConstructConditionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructConditionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructCondition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructCondition, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConstructCondition_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodConstructConditionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var fieldName = this.CreateType<string>();
            var operatorCode = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => SqlHelper.ConstructCondition(fieldName, operatorCode, values, navigatorEntity, parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var fieldName = this.CreateType<string>();
            var operatorCode = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.ConstructCondition(fieldName, operatorCode, values, navigatorEntity, parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var fieldName = this.CreateType<string>();
            var operatorCode = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(string), typeof(Hashtable) };
            object[] parametersOfConstructCondition = { fieldName, operatorCode, values, navigatorEntity, parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructCondition, methodConstructConditionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConstructCondition, parametersOfConstructCondition, methodConstructConditionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConstructCondition);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConstructCondition.ShouldNotBeNull();
            parametersOfConstructCondition.Length.ShouldBe(5);
            methodConstructConditionParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var fieldName = this.CreateType<string>();
            var operatorCode = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(string), typeof(Hashtable) };
            object[] parametersOfConstructCondition = { fieldName, operatorCode, values, navigatorEntity, parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructCondition, parametersOfConstructCondition, methodConstructConditionParametersTypes);

            // Assert
            parametersOfConstructCondition.ShouldNotBeNull();
            parametersOfConstructCondition.Length.ShouldBe(5);
            methodConstructConditionParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(string), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConstructConditionParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var methodConstructConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(string), typeof(Hashtable) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructCondition, methodConstructConditionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructConditionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructCondition, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructCondition) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructCondition_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructCondition, 1);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetOperatorType_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOperatorTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOperatorType, methodGetOperatorTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var operatorCode = this.CreateType<string>();

            // Act
            Action executeAction = () => SqlHelper.GetOperatorType(operatorCode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var operatorCode = this.CreateType<string>();
            var returnedValue = default(SqlHelper.OperatorType);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.GetOperatorType(operatorCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var operatorCode = this.CreateType<string>();
            var methodGetOperatorTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetOperatorType = { operatorCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorType, methodGetOperatorTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOperatorType, methodGetOperatorTypeParametersTypes);
            var result2 = this.GetResultOfMethod<SqlHelper.OperatorType>(MethodGetOperatorType, parametersOfGetOperatorType, methodGetOperatorTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOperatorType.ShouldNotBeNull();
            parametersOfGetOperatorType.Length.ShouldBe(1);
            methodGetOperatorTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<SqlHelper.OperatorType>(MethodGetOperatorType, parametersOfGetOperatorType, methodGetOperatorTypeParametersTypes));
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var operatorCode = this.CreateType<string>();
            var methodGetOperatorTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetOperatorType = { operatorCode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorType, methodGetOperatorTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOperatorType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOperatorType.ShouldNotBeNull();
            parametersOfGetOperatorType.Length.ShouldBe(1);
            methodGetOperatorTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var operatorCode = this.CreateType<string>();
            var methodGetOperatorTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetOperatorType = { operatorCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SqlHelper.OperatorType>(MethodGetOperatorType, parametersOfGetOperatorType, methodGetOperatorTypeParametersTypes);

            // Assert
            parametersOfGetOperatorType.ShouldNotBeNull();
            parametersOfGetOperatorType.Length.ShouldBe(1);
            methodGetOperatorTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var methodGetOperatorTypeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOperatorType, methodGetOperatorTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOperatorTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var methodGetOperatorTypeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOperatorType, methodGetOperatorTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOperatorTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorType) (Return Type : OperatorType) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetOperatorType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_Internally(Type[] types)
        {
            var methodFormatMultipleValuesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValues, methodFormatMultipleValuesParametersTypes);
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();

            // Act
            Action executeAction = () => SqlHelper.FormatMultipleValues(parameterCollection, isString);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.FormatMultipleValues(parameterCollection, isString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var methodFormatMultipleValuesParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            object[] parametersOfFormatMultipleValues = { parameterCollection, isString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValues, methodFormatMultipleValuesParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValues, methodFormatMultipleValuesParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodFormatMultipleValues, parametersOfFormatMultipleValues, methodFormatMultipleValuesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFormatMultipleValues.ShouldNotBeNull();
            parametersOfFormatMultipleValues.Length.ShouldBe(2);
            methodFormatMultipleValuesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodFormatMultipleValues, parametersOfFormatMultipleValues, methodFormatMultipleValuesParametersTypes));
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var methodFormatMultipleValuesParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            object[] parametersOfFormatMultipleValues = { parameterCollection, isString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValues, methodFormatMultipleValuesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfFormatMultipleValues);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFormatMultipleValues.ShouldNotBeNull();
            parametersOfFormatMultipleValues.Length.ShouldBe(2);
            methodFormatMultipleValuesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var methodFormatMultipleValuesParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            object[] parametersOfFormatMultipleValues = { parameterCollection, isString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodFormatMultipleValues, parametersOfFormatMultipleValues, methodFormatMultipleValuesParametersTypes);

            // Assert
            parametersOfFormatMultipleValues.ShouldNotBeNull();
            parametersOfFormatMultipleValues.Length.ShouldBe(2);
            methodFormatMultipleValuesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var methodFormatMultipleValuesParametersTypes = new Type[] { typeof(string[]), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValues, methodFormatMultipleValuesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodFormatMultipleValuesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var methodFormatMultipleValuesParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValues, methodFormatMultipleValuesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFormatMultipleValuesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValues, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (FormatMultipleValues) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValues_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValues);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValues, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_PreProcessParameters_Static_Method_Call_Internally(Type[] types)
        {
            var methodPreProcessParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPreProcessParameters, methodPreProcessParametersParametersTypes);
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var parameters = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var timeZoneOffset = this.CreateType<Double>();
            var siteId = this.CreateType<int>();

            // Act
            Action executeAction = () => SqlHelper.PreProcessParameters(parameters, entityId, timeZoneOffset, siteId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var parameters = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var timeZoneOffset = this.CreateType<Double>();
            var siteId = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.PreProcessParameters(parameters, entityId, timeZoneOffset, siteId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var parameters = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var timeZoneOffset = this.CreateType<Double>();
            var siteId = this.CreateType<int>();
            var methodPreProcessParametersParametersTypes = new Type[] { typeof(string), typeof(int), typeof(Double), typeof(int) };
            object[] parametersOfPreProcessParameters = { parameters, entityId, timeZoneOffset, siteId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPreProcessParameters, methodPreProcessParametersParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodPreProcessParameters, methodPreProcessParametersParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodPreProcessParameters, parametersOfPreProcessParameters, methodPreProcessParametersParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfPreProcessParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPreProcessParameters.ShouldNotBeNull();
            parametersOfPreProcessParameters.Length.ShouldBe(4);
            methodPreProcessParametersParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var parameters = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var timeZoneOffset = this.CreateType<Double>();
            var siteId = this.CreateType<int>();
            var methodPreProcessParametersParametersTypes = new Type[] { typeof(string), typeof(int), typeof(Double), typeof(int) };
            object[] parametersOfPreProcessParameters = { parameters, entityId, timeZoneOffset, siteId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPreProcessParameters, parametersOfPreProcessParameters, methodPreProcessParametersParametersTypes);

            // Assert
            parametersOfPreProcessParameters.ShouldNotBeNull();
            parametersOfPreProcessParameters.Length.ShouldBe(4);
            methodPreProcessParametersParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var methodPreProcessParametersParametersTypes = new Type[] { typeof(string), typeof(int), typeof(Double), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPreProcessParameters, methodPreProcessParametersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPreProcessParametersParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var methodPreProcessParametersParametersTypes = new Type[] { typeof(string), typeof(int), typeof(Double), typeof(int) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPreProcessParameters, methodPreProcessParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPreProcessParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodPreProcessParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PreProcessParameters) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessParameters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodPreProcessParameters, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetFieldType_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFieldTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFieldType, methodGetFieldTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var fieldList = this.CreateType<List<navigator_entity_field_master>>();
            var fieldName = this.CreateType<string>();

            // Act
            Action executeAction = () => SqlHelper.GetFieldType(fieldList, fieldName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var fieldList = this.CreateType<List<navigator_entity_field_master>>();
            var fieldName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.GetFieldType(fieldList, fieldName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var fieldList = this.CreateType<List<navigator_entity_field_master>>();
            var fieldName = this.CreateType<string>();
            var methodGetFieldTypeParametersTypes = new Type[] { typeof(List<navigator_entity_field_master>), typeof(string) };
            object[] parametersOfGetFieldType = { fieldList, fieldName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldType, methodGetFieldTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFieldType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFieldType.ShouldNotBeNull();
            parametersOfGetFieldType.Length.ShouldBe(2);
            methodGetFieldTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var fieldList = this.CreateType<List<navigator_entity_field_master>>();
            var fieldName = this.CreateType<string>();
            var methodGetFieldTypeParametersTypes = new Type[] { typeof(List<navigator_entity_field_master>), typeof(string) };
            object[] parametersOfGetFieldType = { fieldList, fieldName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetFieldType, parametersOfGetFieldType, methodGetFieldTypeParametersTypes);

            // Assert
            parametersOfGetFieldType.ShouldNotBeNull();
            parametersOfGetFieldType.Length.ShouldBe(2);
            methodGetFieldTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var methodGetFieldTypeParametersTypes = new Type[] { typeof(List<navigator_entity_field_master>), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFieldType, methodGetFieldTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetFieldTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var methodGetFieldTypeParametersTypes = new Type[] { typeof(List<navigator_entity_field_master>), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFieldType, methodGetFieldTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFieldTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFieldType) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFieldType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldType, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PreProcessDateOperator) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_PreProcessDateOperator_Static_Method_Call_Internally(Type[] types)
        {
            var methodPreProcessDateOperatorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPreProcessDateOperator, methodPreProcessDateOperatorParametersTypes);
        }

        #endregion

        #region Method Call : (PreProcessDateOperator) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessDateOperator_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessDateOperator);
            var values = this.CreateType<List<string>>();
            var offset = this.CreateType<double>();
            var methodPreProcessDateOperatorParametersTypes = new Type[] { typeof(List<string>), typeof(double) };
            object[] parametersOfPreProcessDateOperator = { values, offset };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPreProcessDateOperator, methodPreProcessDateOperatorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfPreProcessDateOperator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPreProcessDateOperator.ShouldNotBeNull();
            parametersOfPreProcessDateOperator.Length.ShouldBe(2);
            methodPreProcessDateOperatorParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PreProcessDateOperator) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessDateOperator_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessDateOperator);
            var values = this.CreateType<List<string>>();
            var offset = this.CreateType<double>();
            var methodPreProcessDateOperatorParametersTypes = new Type[] { typeof(List<string>), typeof(double) };
            object[] parametersOfPreProcessDateOperator = { values, offset };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPreProcessDateOperator, parametersOfPreProcessDateOperator, methodPreProcessDateOperatorParametersTypes);

            // Assert
            parametersOfPreProcessDateOperator.ShouldNotBeNull();
            parametersOfPreProcessDateOperator.Length.ShouldBe(2);
            methodPreProcessDateOperatorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PreProcessDateOperator) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessDateOperator_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessDateOperator);
            var currentMethodInfo = this.GetMethodInfo(MethodPreProcessDateOperator, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PreProcessDateOperator) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessDateOperator_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessDateOperator);
            var methodPreProcessDateOperatorParametersTypes = new Type[] { typeof(List<string>), typeof(double) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPreProcessDateOperator, methodPreProcessDateOperatorParametersTypes);

            // Assert
            methodPreProcessDateOperatorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PreProcessDateOperator) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_PreProcessDateOperator_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreProcessDateOperator);
            var currentMethodInfo = this.GetMethodInfo(MethodPreProcessDateOperator, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyTimeZoneDifference) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ApplyTimeZoneDifference_Static_Method_Call_Internally(Type[] types)
        {
            var methodApplyTimeZoneDifferenceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyTimeZoneDifference, methodApplyTimeZoneDifferenceParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyTimeZoneDifference) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ApplyTimeZoneDifference_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTimeZoneDifference);
            var offset = this.CreateType<double>();
            var fromDate = this.CreateType<DateTime>();
            var toDate = this.CreateType<DateTime>();
            var methodApplyTimeZoneDifferenceParametersTypes = new Type[] { typeof(double), typeof(DateTime), typeof(DateTime) };
            object[] parametersOfApplyTimeZoneDifference = { offset, fromDate, toDate };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyTimeZoneDifference, methodApplyTimeZoneDifferenceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfApplyTimeZoneDifference);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyTimeZoneDifference.ShouldNotBeNull();
            parametersOfApplyTimeZoneDifference.Length.ShouldBe(3);
            methodApplyTimeZoneDifferenceParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyTimeZoneDifference) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ApplyTimeZoneDifference_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTimeZoneDifference);
            var offset = this.CreateType<double>();
            var fromDate = this.CreateType<DateTime>();
            var toDate = this.CreateType<DateTime>();
            var methodApplyTimeZoneDifferenceParametersTypes = new Type[] { typeof(double), typeof(DateTime), typeof(DateTime) };
            object[] parametersOfApplyTimeZoneDifference = { offset, fromDate, toDate };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodApplyTimeZoneDifference, parametersOfApplyTimeZoneDifference, methodApplyTimeZoneDifferenceParametersTypes);

            // Assert
            parametersOfApplyTimeZoneDifference.ShouldNotBeNull();
            parametersOfApplyTimeZoneDifference.Length.ShouldBe(3);
            methodApplyTimeZoneDifferenceParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyTimeZoneDifference) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ApplyTimeZoneDifference_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTimeZoneDifference);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyTimeZoneDifference, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyTimeZoneDifference) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ApplyTimeZoneDifference_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTimeZoneDifference);
            var methodApplyTimeZoneDifferenceParametersTypes = new Type[] { typeof(double), typeof(DateTime), typeof(DateTime) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyTimeZoneDifference, methodApplyTimeZoneDifferenceParametersTypes);

            // Assert
            methodApplyTimeZoneDifferenceParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyTimeZoneDifference) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ApplyTimeZoneDifference_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTimeZoneDifference);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyTimeZoneDifference, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetSystemParameterValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSystemParameterValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSystemParameterValue, methodGetSystemParameterValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var code = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => SqlHelper.GetSystemParameterValue(code, sessionId, applicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var code = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.GetSystemParameterValue(code, sessionId, applicationName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var code = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodGetSystemParameterValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetSystemParameterValue = { code, sessionId, applicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemParameterValue, methodGetSystemParameterValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetSystemParameterValue, methodGetSystemParameterValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetSystemParameterValue, parametersOfGetSystemParameterValue, methodGetSystemParameterValueParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSystemParameterValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemParameterValue.ShouldNotBeNull();
            parametersOfGetSystemParameterValue.Length.ShouldBe(3);
            methodGetSystemParameterValueParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var code = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodGetSystemParameterValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetSystemParameterValue = { code, sessionId, applicationName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSystemParameterValue, parametersOfGetSystemParameterValue, methodGetSystemParameterValueParametersTypes);

            // Assert
            parametersOfGetSystemParameterValue.ShouldNotBeNull();
            parametersOfGetSystemParameterValue.Length.ShouldBe(3);
            methodGetSystemParameterValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var methodGetSystemParameterValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemParameterValue, methodGetSystemParameterValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemParameterValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var methodGetSystemParameterValueParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemParameterValue, methodGetSystemParameterValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemParameterValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemParameterValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemParameterValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSystemParameterValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemParameterValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemParameterValue, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDateRange) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetDateRange_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetDateRangeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDateRange, methodGetDateRangeParametersTypes);
        }

        #endregion

        #region Method Call : (GetDateRange) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetDateRange_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateRange);
            var empiricalConstant = this.CreateType<string>();
            var fromGmtDate = this.CreateType<DateTime>();
            var toGmtDate = this.CreateType<DateTime>();
            var clientDateTime = this.CreateType<string>();

            // Act
            Action executeAction = () => SqlHelper.GetDateRange(empiricalConstant, out fromGmtDate, out toGmtDate, clientDateTime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetDateRange) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetDateRange_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateRange);
            var empiricalConstant = this.CreateType<string>();
            var fromGmtDate = this.CreateType<DateTime>();
            var toGmtDate = this.CreateType<DateTime>();
            var clientDateTime = this.CreateType<string>();
            var methodGetDateRangeParametersTypes = new Type[] { typeof(string), typeof(DateTime), typeof(DateTime), typeof(string) };
            object[] parametersOfGetDateRange = { empiricalConstant, fromGmtDate, toGmtDate, clientDateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateRange, methodGetDateRangeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDateRange);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetDateRange.ShouldNotBeNull();
            parametersOfGetDateRange.Length.ShouldBe(4);
            methodGetDateRangeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateRange) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetDateRange_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateRange);
            var empiricalConstant = this.CreateType<string>();
            var fromGmtDate = this.CreateType<DateTime>();
            var toGmtDate = this.CreateType<DateTime>();
            var clientDateTime = this.CreateType<string>();
            var methodGetDateRangeParametersTypes = new Type[] { typeof(string), typeof(DateTime), typeof(DateTime), typeof(string) };
            object[] parametersOfGetDateRange = { empiricalConstant, fromGmtDate, toGmtDate, clientDateTime };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetDateRange, parametersOfGetDateRange, methodGetDateRangeParametersTypes);

            // Assert
            parametersOfGetDateRange.ShouldNotBeNull();
            parametersOfGetDateRange.Length.ShouldBe(4);
            methodGetDateRangeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateRange) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetDateRange_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateRange);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateRange, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDateRange) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetDateRange_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateRange);
            var methodGetDateRangeParametersTypes = new Type[] { typeof(string), typeof(DateTime), typeof(DateTime), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDateRange, methodGetDateRangeParametersTypes);

            // Assert
            methodGetDateRangeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateRange) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetDateRange_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateRange);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateRange, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfWeekParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfWeek = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfWeek, parametersOfGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.Length.ShouldBe(1);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfWeek, parametersOfGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfWeek = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfWeek);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfWeek.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.Length.ShouldBe(1);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfWeek = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfWeek, parametersOfGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            parametersOfGetFirstDayOfWeek.ShouldNotBeNull();
            parametersOfGetFirstDayOfWeek.Length.ShouldBe(1);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var methodGetFirstDayOfWeekParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfWeek, methodGetFirstDayOfWeekParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfWeekParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfWeek) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfWeek_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfWeek);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfWeek, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfMonthParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfMonth = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfMonth, parametersOfGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.Length.ShouldBe(1);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfMonth, parametersOfGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfMonth = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfMonth);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfMonth.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.Length.ShouldBe(1);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfMonth = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfMonth, parametersOfGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            parametersOfGetFirstDayOfMonth.ShouldNotBeNull();
            parametersOfGetFirstDayOfMonth.Length.ShouldBe(1);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var methodGetFirstDayOfMonthParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfMonth, methodGetFirstDayOfMonthParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfMonthParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfMonth) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfMonth_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfMonth);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfMonth, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfQuarterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfQuarter = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfQuarter, parametersOfGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.Length.ShouldBe(1);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfQuarter, parametersOfGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfQuarter = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfQuarter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfQuarter.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.Length.ShouldBe(1);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfQuarter = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfQuarter, parametersOfGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            parametersOfGetFirstDayOfQuarter.ShouldNotBeNull();
            parametersOfGetFirstDayOfQuarter.Length.ShouldBe(1);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var methodGetFirstDayOfQuarterParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfQuarter, methodGetFirstDayOfQuarterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfQuarterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfQuarter) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfQuarter_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfQuarter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfQuarter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFirstDayOfYearParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfYear = { dateTime };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfYear, parametersOfGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.Length.ShouldBe(1);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfYear, parametersOfGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes));
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfYear = { dateTime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFirstDayOfYear);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFirstDayOfYear.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.Length.ShouldBe(1);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var dateTime = this.CreateType<DateTime>();
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfGetFirstDayOfYear = { dateTime };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodGetFirstDayOfYear, parametersOfGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            parametersOfGetFirstDayOfYear.ShouldNotBeNull();
            parametersOfGetFirstDayOfYear.Length.ShouldBe(1);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var methodGetFirstDayOfYearParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFirstDayOfYear, methodGetFirstDayOfYearParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFirstDayOfYearParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFirstDayOfYear) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetFirstDayOfYear_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFirstDayOfYear);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFirstDayOfYear, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Internally(Type[] types)
        {
            var methodConvertToGmtDateTimeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<DateTime>();
            var utcOffset = this.CreateType<double>();

            // Act
            Action executeAction = () => SqlHelper.ConvertToGmtDateTime(clientDateTime, utcOffset);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<DateTime>();
            var utcOffset = this.CreateType<double>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.ConvertToGmtDateTime(clientDateTime, utcOffset);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<DateTime>();
            var utcOffset = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(DateTime), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, utcOffset };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(2);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<DateTime>();
            var utcOffset = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(DateTime), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, utcOffset };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConvertToGmtDateTime);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(2);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<DateTime>();
            var utcOffset = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(DateTime), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, utcOffset };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(2);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(DateTime), typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(DateTime), typeof(double) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodConvertToGmtDateTimeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();

            // Act
            Action executeAction = () => SqlHelper.ConvertToGmtDateTime(clientDateTime, utcOffSet);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.ConvertToGmtDateTime(clientDateTime, utcOffSet);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, utcOffSet };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(2);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, utcOffSet };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConvertToGmtDateTime);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(2);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, utcOffSet };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(2);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(double) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodConvertToGmtDateTimeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_DirectCall_Overloading_Of_2_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var dateFormat = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();

            // Act
            Action executeAction = () => SqlHelper.ConvertToGmtDateTime(clientDateTime, dateFormat, utcOffSet);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_DirectCall_Overloading_Of_2_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var dateFormat = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.ConvertToGmtDateTime(clientDateTime, dateFormat, utcOffSet);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_2_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var dateFormat = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, dateFormat, utcOffSet };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(3);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_2_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var dateFormat = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, dateFormat, utcOffSet };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConvertToGmtDateTime);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(3);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var clientDateTime = this.CreateType<string>();
            var dateFormat = this.CreateType<string>();
            var utcOffSet = this.CreateType<double>();
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(double) };
            object[] parametersOfConvertToGmtDateTime = { clientDateTime, dateFormat, utcOffSet };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertToGmtDateTime, parametersOfConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            parametersOfConvertToGmtDateTime.ShouldNotBeNull();
            parametersOfConvertToGmtDateTime.Length.ShouldBe(3);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var methodConvertToGmtDateTimeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(double) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToGmtDateTime, methodConvertToGmtDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToGmtDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToGmtDateTime) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConvertToGmtDateTime_Static_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToGmtDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToGmtDateTime, 2);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckSystemMaxRecordLimit) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_CheckSystemMaxRecordLimit_Static_Method_Call_Internally(Type[] types)
        {
            var methodCheckSystemMaxRecordLimitParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckSystemMaxRecordLimit, methodCheckSystemMaxRecordLimitParametersTypes);
        }

        #endregion

        #region Method Call : (CheckSystemMaxRecordLimit) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CheckSystemMaxRecordLimit_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckSystemMaxRecordLimit);
            var entityConfiguration = this.CreateType<EntityConfiguration>();
            var methodCheckSystemMaxRecordLimitParametersTypes = new Type[] { typeof(EntityConfiguration) };
            object[] parametersOfCheckSystemMaxRecordLimit = { entityConfiguration };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckSystemMaxRecordLimit, parametersOfCheckSystemMaxRecordLimit, methodCheckSystemMaxRecordLimitParametersTypes);

            // Assert
            parametersOfCheckSystemMaxRecordLimit.ShouldNotBeNull();
            parametersOfCheckSystemMaxRecordLimit.Length.ShouldBe(1);
            methodCheckSystemMaxRecordLimitParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckSystemMaxRecordLimit) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CheckSystemMaxRecordLimit_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckSystemMaxRecordLimit);
            var methodCheckSystemMaxRecordLimitParametersTypes = new Type[] { typeof(EntityConfiguration) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckSystemMaxRecordLimit, methodCheckSystemMaxRecordLimitParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckSystemMaxRecordLimitParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckSystemMaxRecordLimit) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CheckSystemMaxRecordLimit_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckSystemMaxRecordLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckSystemMaxRecordLimit, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckSystemMaxRecordLimit) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CheckSystemMaxRecordLimit_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckSystemMaxRecordLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckSystemMaxRecordLimit, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsExistsConditionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsExistsCondition, methodIsExistsConditionParametersTypes);
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var viewName = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var methodIsExistsConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfIsExistsCondition = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, viewName, ownerType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsExistsCondition, methodIsExistsConditionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsExistsCondition, methodIsExistsConditionParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsExistsCondition, parametersOfIsExistsCondition, methodIsExistsConditionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsExistsCondition.ShouldNotBeNull();
            parametersOfIsExistsCondition.Length.ShouldBe(6);
            methodIsExistsConditionParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsExistsCondition, parametersOfIsExistsCondition, methodIsExistsConditionParametersTypes));
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var viewName = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var methodIsExistsConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfIsExistsCondition = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, viewName, ownerType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsExistsCondition, methodIsExistsConditionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfIsExistsCondition);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsExistsCondition.ShouldNotBeNull();
            parametersOfIsExistsCondition.Length.ShouldBe(6);
            methodIsExistsConditionParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var viewName = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var methodIsExistsConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfIsExistsCondition = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, viewName, ownerType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsExistsCondition, parametersOfIsExistsCondition, methodIsExistsConditionParametersTypes);

            // Assert
            parametersOfIsExistsCondition.ShouldNotBeNull();
            parametersOfIsExistsCondition.Length.ShouldBe(6);
            methodIsExistsConditionParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var methodIsExistsConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsExistsCondition, methodIsExistsConditionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsExistsConditionParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var methodIsExistsConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsExistsCondition, methodIsExistsConditionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsExistsConditionParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var methodIsExistsConditionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsExistsCondition, methodIsExistsConditionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsExistsConditionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodIsExistsCondition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsExistsCondition) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_IsExistsCondition_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsExistsCondition);
            var currentMethodInfo = this.GetMethodInfo(MethodIsExistsCondition, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_Internally(Type[] types)
        {
            var methodConstructORCodintionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructORCodintions, methodConstructORCodintionsParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintions);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var viewName = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var methodConstructORCodintionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string), typeof(List<string>) };
            object[] parametersOfConstructORCodintions = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, viewName, ownerType, values };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintions, methodConstructORCodintionsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConstructORCodintions, methodConstructORCodintionsParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConstructORCodintions, parametersOfConstructORCodintions, methodConstructORCodintionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConstructORCodintions.ShouldNotBeNull();
            parametersOfConstructORCodintions.Length.ShouldBe(7);
            methodConstructORCodintionsParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConstructORCodintions, parametersOfConstructORCodintions, methodConstructORCodintionsParametersTypes));
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintions);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var viewName = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var methodConstructORCodintionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string), typeof(List<string>) };
            object[] parametersOfConstructORCodintions = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, viewName, ownerType, values };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintions, methodConstructORCodintionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConstructORCodintions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConstructORCodintions.ShouldNotBeNull();
            parametersOfConstructORCodintions.Length.ShouldBe(7);
            methodConstructORCodintionsParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintions);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var viewName = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var methodConstructORCodintionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string), typeof(List<string>) };
            object[] parametersOfConstructORCodintions = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, viewName, ownerType, values };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructORCodintions, parametersOfConstructORCodintions, methodConstructORCodintionsParametersTypes);

            // Assert
            parametersOfConstructORCodintions.ShouldNotBeNull();
            parametersOfConstructORCodintions.Length.ShouldBe(7);
            methodConstructORCodintionsParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintions);
            var methodConstructORCodintionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string), typeof(List<string>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructORCodintions, methodConstructORCodintionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConstructORCodintionsParametersTypes.Length.ShouldBe(7);
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintions);
            var methodConstructORCodintionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(string), typeof(string), typeof(List<string>) };
            const int parametersCount = 7;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructORCodintions, methodConstructORCodintionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructORCodintionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintions);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConstructORCodintions) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintions_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintions);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintions, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSQLInjectionSafeStingParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes);
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLInjectionSafeSting);
            var value = this.CreateType<string>();
            var operatorCode = this.CreateType<string>();
            var methodGetSQLInjectionSafeStingParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSQLInjectionSafeSting = { value, operatorCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetSQLInjectionSafeSting, parametersOfGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetSQLInjectionSafeSting.ShouldNotBeNull();
            parametersOfGetSQLInjectionSafeSting.Length.ShouldBe(2);
            methodGetSQLInjectionSafeStingParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetSQLInjectionSafeSting, parametersOfGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes));
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLInjectionSafeSting);
            var value = this.CreateType<string>();
            var operatorCode = this.CreateType<string>();
            var methodGetSQLInjectionSafeStingParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSQLInjectionSafeSting = { value, operatorCode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSQLInjectionSafeSting);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSQLInjectionSafeSting.ShouldNotBeNull();
            parametersOfGetSQLInjectionSafeSting.Length.ShouldBe(2);
            methodGetSQLInjectionSafeStingParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLInjectionSafeSting);
            var value = this.CreateType<string>();
            var operatorCode = this.CreateType<string>();
            var methodGetSQLInjectionSafeStingParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSQLInjectionSafeSting = { value, operatorCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSQLInjectionSafeSting, parametersOfGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes);

            // Assert
            parametersOfGetSQLInjectionSafeSting.ShouldNotBeNull();
            parametersOfGetSQLInjectionSafeSting.Length.ShouldBe(2);
            methodGetSQLInjectionSafeStingParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLInjectionSafeSting);
            var methodGetSQLInjectionSafeStingParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetSQLInjectionSafeStingParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLInjectionSafeSting);
            var methodGetSQLInjectionSafeStingParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSQLInjectionSafeSting, methodGetSQLInjectionSafeStingParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSQLInjectionSafeStingParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLInjectionSafeSting);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSQLInjectionSafeSting, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetSQLInjectionSafeSting) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_GetSQLInjectionSafeSting_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLInjectionSafeSting);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSQLInjectionSafeSting, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateSearchLBOParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateSearchLBOParameter, methodCreateSearchLBOParameterParametersTypes);
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => SqlHelper.CreateSearchLBOParameter(key, navigatorEntity, parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.CreateSearchLBOParameter(key, navigatorEntity, parameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodCreateSearchLBOParameterParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfCreateSearchLBOParameter = { key, navigatorEntity, parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSearchLBOParameter, methodCreateSearchLBOParameterParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateSearchLBOParameter, methodCreateSearchLBOParameterParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodCreateSearchLBOParameter, parametersOfCreateSearchLBOParameter, methodCreateSearchLBOParameterParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateSearchLBOParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateSearchLBOParameter.ShouldNotBeNull();
            parametersOfCreateSearchLBOParameter.Length.ShouldBe(3);
            methodCreateSearchLBOParameterParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodCreateSearchLBOParameterParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfCreateSearchLBOParameter = { key, navigatorEntity, parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateSearchLBOParameter, parametersOfCreateSearchLBOParameter, methodCreateSearchLBOParameterParametersTypes);

            // Assert
            parametersOfCreateSearchLBOParameter.ShouldNotBeNull();
            parametersOfCreateSearchLBOParameter.Length.ShouldBe(3);
            methodCreateSearchLBOParameterParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var methodCreateSearchLBOParameterParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateSearchLBOParameter, methodCreateSearchLBOParameterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateSearchLBOParameterParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var methodCreateSearchLBOParameterParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateSearchLBOParameter, methodCreateSearchLBOParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateSearchLBOParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSearchLBOParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateSearchLBOParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_CreateSearchLBOParameter_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSearchLBOParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSearchLBOParameter, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_Internally(Type[] types)
        {
            var methodFormatMultipleValuesForProcudureParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes);
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();

            // Act
            Action executeAction = () => SqlHelper.FormatMultipleValuesForProcudure(parameterCollection, isString);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SqlHelper.FormatMultipleValuesForProcudure(parameterCollection, isString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var methodFormatMultipleValuesForProcudureParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            object[] parametersOfFormatMultipleValuesForProcudure = { parameterCollection, isString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodFormatMultipleValuesForProcudure, parametersOfFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFormatMultipleValuesForProcudure.ShouldNotBeNull();
            parametersOfFormatMultipleValuesForProcudure.Length.ShouldBe(2);
            methodFormatMultipleValuesForProcudureParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodFormatMultipleValuesForProcudure, parametersOfFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes));
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var methodFormatMultipleValuesForProcudureParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            object[] parametersOfFormatMultipleValuesForProcudure = { parameterCollection, isString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfFormatMultipleValuesForProcudure);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFormatMultipleValuesForProcudure.ShouldNotBeNull();
            parametersOfFormatMultipleValuesForProcudure.Length.ShouldBe(2);
            methodFormatMultipleValuesForProcudureParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var parameterCollection = this.CreateType<string[]>();
            var isString = this.CreateType<bool>();
            var methodFormatMultipleValuesForProcudureParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            object[] parametersOfFormatMultipleValuesForProcudure = { parameterCollection, isString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodFormatMultipleValuesForProcudure, parametersOfFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes);

            // Assert
            parametersOfFormatMultipleValuesForProcudure.ShouldNotBeNull();
            parametersOfFormatMultipleValuesForProcudure.Length.ShouldBe(2);
            methodFormatMultipleValuesForProcudureParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var methodFormatMultipleValuesForProcudureParametersTypes = new Type[] { typeof(string[]), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodFormatMultipleValuesForProcudureParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var methodFormatMultipleValuesForProcudureParametersTypes = new Type[] { typeof(string[]), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFormatMultipleValuesForProcudure, methodFormatMultipleValuesForProcudureParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFormatMultipleValuesForProcudureParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValuesForProcudure, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (FormatMultipleValuesForProcudure) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_FormatMultipleValuesForProcudure_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatMultipleValuesForProcudure);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatMultipleValuesForProcudure, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_Internally(Type[] types)
        {
            var methodConstructORCodintionsForProcudureParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintionsForProcudure);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var methodConstructORCodintionsForProcudureParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(List<string>) };
            object[] parametersOfConstructORCodintionsForProcudure = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, values };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConstructORCodintionsForProcudure, parametersOfConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConstructORCodintionsForProcudure.ShouldNotBeNull();
            parametersOfConstructORCodintionsForProcudure.Length.ShouldBe(5);
            methodConstructORCodintionsForProcudureParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConstructORCodintionsForProcudure, parametersOfConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes));
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintionsForProcudure);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var methodConstructORCodintionsForProcudureParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(List<string>) };
            object[] parametersOfConstructORCodintionsForProcudure = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, values };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConstructORCodintionsForProcudure);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConstructORCodintionsForProcudure.ShouldNotBeNull();
            parametersOfConstructORCodintionsForProcudure.Length.ShouldBe(5);
            methodConstructORCodintionsForProcudureParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintionsForProcudure);
            var navigatorEntity = this.CreateType<string>();
            var fieldName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var conditionTemplate = this.CreateType<string>();
            var values = this.CreateType<List<string>>();
            var methodConstructORCodintionsForProcudureParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(List<string>) };
            object[] parametersOfConstructORCodintionsForProcudure = { navigatorEntity, fieldName, parameterCollection, conditionTemplate, values };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructORCodintionsForProcudure, parametersOfConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes);

            // Assert
            parametersOfConstructORCodintionsForProcudure.ShouldNotBeNull();
            parametersOfConstructORCodintionsForProcudure.Length.ShouldBe(5);
            methodConstructORCodintionsForProcudureParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintionsForProcudure);
            var methodConstructORCodintionsForProcudureParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(List<string>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConstructORCodintionsForProcudureParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintionsForProcudure);
            var methodConstructORCodintionsForProcudureParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string), typeof(List<string>) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructORCodintionsForProcudure, methodConstructORCodintionsForProcudureParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructORCodintionsForProcudureParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintionsForProcudure);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintionsForProcudure, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConstructORCodintionsForProcudure) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SqlHelper_ConstructORCodintionsForProcudure_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructORCodintionsForProcudure);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructORCodintionsForProcudure, 0);
            const int parametersCount = 5;

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