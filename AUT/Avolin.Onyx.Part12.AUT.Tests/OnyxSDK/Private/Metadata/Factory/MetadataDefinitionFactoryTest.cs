using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OnyxSDK.Private.Metadata.Factory;
using OnyxSDK.Public.Interface;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata.Factory
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.Factory.MetadataDefinitionFactory" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata.Factory"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MetadataDefinitionFactoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MetadataDefinitionFactory" />)
        /// </summary>
        public MetadataDefinitionFactoryTest() : base(typeof(MetadataDefinitionFactory))
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

        #region General Initializer : Class (MetadataDefinitionFactory) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _metadataDefinitionFactoryInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="MetadataDefinitionFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _metadataDefinitionFactoryInstanceType = typeof(MetadataDefinitionFactory);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MetadataDefinitionFactory) Initializer

        #region Methods

        private const string MethodGetObjectDefintion = "GetObjectDefintion";
        private const string MethodGetObjectList = "GetObjectList";

        #endregion

        #region Fields

        private const string FieldObjectListCache = "ObjectListCache";
        private const string FieldObjectDefinitionCache = "ObjectDefinitionCache";
        private const string Field_onyxLock = "_onyxLock";
        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region General Initializer : Class (MetadataDefinitionFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MetadataDefinitionFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MetadataDefinitionFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MetadataDefinitionFactory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MetadataDefinitionFactory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MetadataDefinitionFactory_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MetadataDefinitionFactory)

        #region General Initializer : Class (MetadataDefinitionFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MetadataDefinitionFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetObjectDefintion, 0)]
        [TestCase(MethodGetObjectList, 0)]
        public void AUT_MetadataDefinitionFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MetadataDefinitionFactory) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MetadataDefinitionFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldObjectListCache)]
        [TestCase(FieldObjectDefinitionCache)]
        [TestCase(Field_onyxLock)]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_MetadataDefinitionFactory_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MetadataDefinitionFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MetadataDefinitionFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MetadataDefinitionFactory_Is_Static_Type_Present_Test()
        {
            // Assert
            _metadataDefinitionFactoryInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var objectName = this.CreateType<string>();

            // Act
            Action executeAction = () => MetadataDefinitionFactory.GetObjectDefintion(onyxUserContext, objectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var objectName = this.CreateType<string>();
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = MetadataDefinitionFactory.GetObjectDefintion(onyxUserContext, objectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var objectName = this.CreateType<string>();
            var methodGetObjectDefintionParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string) };
            object[] parametersOfGetObjectDefintion = { onyxUserContext, objectName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectDefintion, methodGetObjectDefintionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetObjectDefintion, methodGetObjectDefintionParametersTypes);
            var result2 = this.GetResultOfMethod<JObject>(MethodGetObjectDefintion, parametersOfGetObjectDefintion, methodGetObjectDefintionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetObjectDefintion);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectDefintion.ShouldNotBeNull();
            parametersOfGetObjectDefintion.Length.ShouldBe(2);
            methodGetObjectDefintionParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var objectName = this.CreateType<string>();
            var methodGetObjectDefintionParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string) };
            object[] parametersOfGetObjectDefintion = { onyxUserContext, objectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JObject>(MethodGetObjectDefintion, parametersOfGetObjectDefintion, methodGetObjectDefintionParametersTypes);

            // Assert
            parametersOfGetObjectDefintion.ShouldNotBeNull();
            parametersOfGetObjectDefintion.Length.ShouldBe(2);
            methodGetObjectDefintionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var methodGetObjectDefintionParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectDefintion, methodGetObjectDefintionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectDefintionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var methodGetObjectDefintionParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectDefintion, methodGetObjectDefintionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectDefintionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectDefintion, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectDefintion) (Return Type : JObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectDefintion_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectDefintion);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectDefintion, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectList, methodGetObjectListParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();

            // Act
            Action executeAction = () => MetadataDefinitionFactory.GetObjectList(onyxUserContext);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = MetadataDefinitionFactory.GetObjectList(onyxUserContext);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetObjectListParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetObjectList = { onyxUserContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectList, methodGetObjectListParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetObjectList, methodGetObjectListParametersTypes);
            var result2 = this.GetResultOfMethod<JObject>(MethodGetObjectList, parametersOfGetObjectList, methodGetObjectListParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetObjectList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectList.ShouldNotBeNull();
            parametersOfGetObjectList.Length.ShouldBe(1);
            methodGetObjectListParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetObjectListParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetObjectList = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JObject>(MethodGetObjectList, parametersOfGetObjectList, methodGetObjectListParametersTypes);

            // Assert
            parametersOfGetObjectList.ShouldNotBeNull();
            parametersOfGetObjectList.Length.ShouldBe(1);
            methodGetObjectListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var methodGetObjectListParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectList, methodGetObjectListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectListParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var methodGetObjectListParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectList, methodGetObjectListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectList) (Return Type : JObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MetadataDefinitionFactory_GetObjectList_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectList, 0);
            const int parametersCount = 1;

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