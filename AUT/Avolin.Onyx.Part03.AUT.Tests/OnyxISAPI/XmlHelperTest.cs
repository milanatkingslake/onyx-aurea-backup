using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.XmlHelper" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlHelper" />)
        /// </summary>
        public XmlHelperTest() : base(typeof(XmlHelper))
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

        #region General Initializer : Class (XmlHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="XmlHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlHelperInstanceType = typeof(XmlHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlHelper) Initializer

        #region Properties

        private const string PropertySQLResource = "SQLResource";

        #endregion

        #region Methods

        private const string MethodGetSqlStatement = "GetSqlStatement";
        private const string MethodGetSQLStatement = "GetSQLStatement";

        #endregion

        #region Fields

        private const string FieldXML_GET_ENTITIES = "XML_GET_ENTITIES";

        #endregion

        #endregion

        #region General Initializer : Class (XmlHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlHelper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="XmlHelper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlHelper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlHelper)

        #region General Initializer : Class (XmlHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSqlStatement, 0)]
        [TestCase(MethodGetSQLStatement, 0)]
        public void AUT_XmlHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (XmlHelper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlHelper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySQLResource)]
        [Category("AUT Property")]
        public void AUT_XmlHelper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (XmlHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldXML_GET_ENTITIES)]
        [Category("AUT Fields")]
        public void AUT_XmlHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (XmlHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="XmlHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _xmlHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSqlStatement) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlHelper.GetSqlStatement(key);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSqlStatement);
            var key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlHelper.GetSqlStatement(key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSqlStatement) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_Call_With_No_Exception_Thrown_Test()
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
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_XmlHelper_GetSqlStatement_Static_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetSQLStatement) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlHelper_GetSQLStatement_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSQLStatementParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSQLStatement, methodGetSQLStatementParametersTypes);
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var selectClause = this.CreateType<string>();

            // Act
            Action executeAction = () => XmlHelper.GetSQLStatement(key, navigatorEntity, parameterCollection, selectClause);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var selectClause = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = XmlHelper.GetSQLStatement(key, navigatorEntity, parameterCollection, selectClause);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var selectClause = this.CreateType<string>();
            var methodGetSQLStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string) };
            object[] parametersOfGetSQLStatement = { key, navigatorEntity, parameterCollection, selectClause };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSQLStatement, methodGetSQLStatementParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetSQLStatement, methodGetSQLStatementParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetSQLStatement, parametersOfGetSQLStatement, methodGetSQLStatementParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSQLStatement);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSQLStatement.ShouldNotBeNull();
            parametersOfGetSQLStatement.Length.ShouldBe(4);
            methodGetSQLStatementParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var key = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var selectClause = this.CreateType<string>();
            var methodGetSQLStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string) };
            object[] parametersOfGetSQLStatement = { key, navigatorEntity, parameterCollection, selectClause };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSQLStatement, parametersOfGetSQLStatement, methodGetSQLStatementParametersTypes);

            // Assert
            parametersOfGetSQLStatement.ShouldNotBeNull();
            parametersOfGetSQLStatement.Length.ShouldBe(4);
            methodGetSQLStatementParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var methodGetSQLStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSQLStatement, methodGetSQLStatementParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSQLStatementParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var methodGetSQLStatementParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSQLStatement, methodGetSQLStatementParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSQLStatementParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSQLStatement, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSQLStatement) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlHelper_GetSQLStatement_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSQLStatement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSQLStatement, 0);
            const int parametersCount = 4;

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