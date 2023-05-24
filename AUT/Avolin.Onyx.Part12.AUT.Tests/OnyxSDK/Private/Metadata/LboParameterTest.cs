using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OnyxSDK.Private.Metadata;
using OnyxSDK.Public.Interface;
using OnyxSDK.Public.Interface.Metadata;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.LboParameter" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class LboParameterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboParameter" />)
        /// </summary>
        public LboParameterTest() : base(typeof(LboParameter))
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

        #region General Initializer : Class (LboParameter) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboParameterInstanceType;
        private LboParameter _lboParameterInstance;
        private LboParameter _lboParameterInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboParameter" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboParameterInstanceType = typeof(LboParameter);
            _lboParameterInstanceFixture = this.Create<LboParameter>(false);
            _lboParameterInstance = _lboParameterInstanceFixture ?? this.Create<LboParameter>(true);
            CurrentInstance = _lboParameterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboParameter) Initializer

        #region Methods

        private const string MethodGetContentProperties = "GetContentProperties";
        private const string MethodSetKeysOnlyProperties = "SetKeysOnlyProperties";
        private const string MethodSetPartialProperties = "SetPartialProperties";
        private const string MethodSetAllOrAnyProperties = "SetAllOrAnyProperties";
        private const string MethodGetRawParameter = "GetRawParameter";
        private const string MethodGetRowsetProperties = "GetRowsetProperties";
        private const string MethodGetParameter = "GetParameter";
        private const string MethodGetObjectParameter = "GetObjectParameter";
        private const string MethodGetCollectionParameter = "GetCollectionParameter";
        private const string MethodGetObjectInstanceParameter = "GetObjectInstanceParameter";
        private const string MethodGetObjectInstanceContentProperties = "GetObjectInstanceContentProperties";

        #endregion

        #region Fields

        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region General Initializer : Class (LboParameter) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboParameter" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboParameter_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboParameter) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LboParameter" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboParameter_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboParameter) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboParameter" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboParameter_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboParameter)

        #region General Initializer : Class (LboParameter) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboParameter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetContentProperties, 0)]
        [TestCase(MethodSetKeysOnlyProperties, 0)]
        [TestCase(MethodSetPartialProperties, 0)]
        [TestCase(MethodSetAllOrAnyProperties, 0)]
        [TestCase(MethodGetRawParameter, 0)]
        [TestCase(MethodGetRowsetProperties, 0)]
        [TestCase(MethodGetRawParameter, 1)]
        [TestCase(MethodGetParameter, 0)]
        [TestCase(MethodGetObjectParameter, 0)]
        [TestCase(MethodGetCollectionParameter, 0)]
        [TestCase(MethodGetObjectInstanceParameter, 0)]
        [TestCase(MethodGetObjectInstanceContentProperties, 0)]
        public void AUT_LboParameter_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LboParameter) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboParameter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_LboParameter_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboParameter) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboParameter" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboParameter_Is_Instance_Present_Test()
        {
            // Assert
            _lboParameterInstanceType.ShouldNotBeNull();
            _lboParameterInstance.ShouldNotBeNull();
            _lboParameterInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (LboParameter) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboParameter" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboParameter_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboParameterInstance.ShouldBeAssignableTo<LboParameter>();
            _lboParameterInstanceFixture.ShouldBeAssignableTo<LboParameter>();
            CurrentInstance.ShouldBeAssignableTo<LboParameter>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetContentProperties) (Return Type : IList<ILboProperty>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetContentProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetContentProperties = { onyxUserContext };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContentProperties, methodGetContentPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboProperty>>(_lboParameterInstanceFixture, out exception1, parametersOfGetContentProperties);
            var result2 = this.GetResultOfMethod<IList<ILboProperty>>(MethodGetContentProperties, parametersOfGetContentProperties, methodGetContentPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetContentProperties.ShouldNotBeNull();
            parametersOfGetContentProperties.Length.ShouldBe(1);
            methodGetContentPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContentProperties) (Return Type : IList<ILboProperty>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetContentProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetContentProperties = { onyxUserContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContentProperties, methodGetContentPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetContentProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetContentProperties.ShouldNotBeNull();
            parametersOfGetContentProperties.Length.ShouldBe(1);
            methodGetContentPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContentProperties) (Return Type : IList<ILboProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetContentProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetContentProperties = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboProperty>>(MethodGetContentProperties, parametersOfGetContentProperties, methodGetContentPropertiesParametersTypes);

            // Assert
            parametersOfGetContentProperties.ShouldNotBeNull();
            parametersOfGetContentProperties.Length.ShouldBe(1);
            methodGetContentPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContentProperties) (Return Type : IList<ILboProperty>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetContentProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentProperties);
            var methodGetContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContentProperties, methodGetContentPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetContentPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContentProperties) (Return Type : IList<ILboProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetContentProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentProperties);
            var methodGetContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContentProperties, methodGetContentPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContentPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContentProperties) (Return Type : IList<ILboProperty>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetContentProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContentProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetContentProperties) (Return Type : IList<ILboProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetContentProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContentProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContentProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_Internally(Type[] types)
        {
            var methodSetKeysOnlyPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetKeysOnlyProperties, methodSetKeysOnlyPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetKeysOnlyProperties);
            var lboObject = this.CreateType<ILboObject>();
            var methodSetKeysOnlyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            object[] parametersOfSetKeysOnlyProperties = { lboObject };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetKeysOnlyProperties, methodSetKeysOnlyPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboProperty>>(_lboParameterInstanceFixture, out exception1, parametersOfSetKeysOnlyProperties);
            var result2 = this.GetResultOfMethod<IList<ILboProperty>>(MethodSetKeysOnlyProperties, parametersOfSetKeysOnlyProperties, methodSetKeysOnlyPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetKeysOnlyProperties.ShouldNotBeNull();
            parametersOfSetKeysOnlyProperties.Length.ShouldBe(1);
            methodSetKeysOnlyPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetKeysOnlyProperties);
            var lboObject = this.CreateType<ILboObject>();
            var methodSetKeysOnlyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            object[] parametersOfSetKeysOnlyProperties = { lboObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetKeysOnlyProperties, methodSetKeysOnlyPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfSetKeysOnlyProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetKeysOnlyProperties.ShouldNotBeNull();
            parametersOfSetKeysOnlyProperties.Length.ShouldBe(1);
            methodSetKeysOnlyPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetKeysOnlyProperties);
            var lboObject = this.CreateType<ILboObject>();
            var methodSetKeysOnlyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            object[] parametersOfSetKeysOnlyProperties = { lboObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboProperty>>(MethodSetKeysOnlyProperties, parametersOfSetKeysOnlyProperties, methodSetKeysOnlyPropertiesParametersTypes);

            // Assert
            parametersOfSetKeysOnlyProperties.ShouldNotBeNull();
            parametersOfSetKeysOnlyProperties.Length.ShouldBe(1);
            methodSetKeysOnlyPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetKeysOnlyProperties);
            var methodSetKeysOnlyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetKeysOnlyProperties, methodSetKeysOnlyPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetKeysOnlyPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetKeysOnlyProperties);
            var methodSetKeysOnlyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetKeysOnlyProperties, methodSetKeysOnlyPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetKeysOnlyPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetKeysOnlyProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetKeysOnlyProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetKeysOnlyProperties) (Return Type : IList<ILboProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetKeysOnlyProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetKeysOnlyProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetKeysOnlyProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_SetPartialProperties_Method_Call_Internally(Type[] types)
        {
            var methodSetPartialPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetPartialProperties, methodSetPartialPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetPartialProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPartialProperties);
            var parameter = this.CreateType<JObject>();
            var methodSetPartialPropertiesParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfSetPartialProperties = { parameter };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPartialProperties, methodSetPartialPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboProperty>>(_lboParameterInstanceFixture, out exception1, parametersOfSetPartialProperties);
            var result2 = this.GetResultOfMethod<IList<ILboProperty>>(MethodSetPartialProperties, parametersOfSetPartialProperties, methodSetPartialPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetPartialProperties.ShouldNotBeNull();
            parametersOfSetPartialProperties.Length.ShouldBe(1);
            methodSetPartialPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetPartialProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPartialProperties);
            var parameter = this.CreateType<JObject>();
            var methodSetPartialPropertiesParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfSetPartialProperties = { parameter };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPartialProperties, methodSetPartialPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfSetPartialProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPartialProperties.ShouldNotBeNull();
            parametersOfSetPartialProperties.Length.ShouldBe(1);
            methodSetPartialPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetPartialProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPartialProperties);
            var parameter = this.CreateType<JObject>();
            var methodSetPartialPropertiesParametersTypes = new Type[] { typeof(JObject) };
            object[] parametersOfSetPartialProperties = { parameter };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboProperty>>(MethodSetPartialProperties, parametersOfSetPartialProperties, methodSetPartialPropertiesParametersTypes);

            // Assert
            parametersOfSetPartialProperties.ShouldNotBeNull();
            parametersOfSetPartialProperties.Length.ShouldBe(1);
            methodSetPartialPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetPartialProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPartialProperties);
            var methodSetPartialPropertiesParametersTypes = new Type[] { typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetPartialProperties, methodSetPartialPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetPartialPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetPartialProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPartialProperties);
            var methodSetPartialPropertiesParametersTypes = new Type[] { typeof(JObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPartialProperties, methodSetPartialPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetPartialPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetPartialProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPartialProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPartialProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetPartialProperties) (Return Type : IList<ILboProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetPartialProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPartialProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPartialProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_Internally(Type[] types)
        {
            var methodSetAllOrAnyPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetAllOrAnyProperties, methodSetAllOrAnyPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAllOrAnyProperties);
            var lboObject = this.CreateType<ILboObject>();
            var methodSetAllOrAnyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            object[] parametersOfSetAllOrAnyProperties = { lboObject };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetAllOrAnyProperties, methodSetAllOrAnyPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboProperty>>(_lboParameterInstanceFixture, out exception1, parametersOfSetAllOrAnyProperties);
            var result2 = this.GetResultOfMethod<IList<ILboProperty>>(MethodSetAllOrAnyProperties, parametersOfSetAllOrAnyProperties, methodSetAllOrAnyPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetAllOrAnyProperties.ShouldNotBeNull();
            parametersOfSetAllOrAnyProperties.Length.ShouldBe(1);
            methodSetAllOrAnyPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAllOrAnyProperties);
            var lboObject = this.CreateType<ILboObject>();
            var methodSetAllOrAnyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            object[] parametersOfSetAllOrAnyProperties = { lboObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetAllOrAnyProperties, methodSetAllOrAnyPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfSetAllOrAnyProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetAllOrAnyProperties.ShouldNotBeNull();
            parametersOfSetAllOrAnyProperties.Length.ShouldBe(1);
            methodSetAllOrAnyPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAllOrAnyProperties);
            var lboObject = this.CreateType<ILboObject>();
            var methodSetAllOrAnyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            object[] parametersOfSetAllOrAnyProperties = { lboObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboProperty>>(MethodSetAllOrAnyProperties, parametersOfSetAllOrAnyProperties, methodSetAllOrAnyPropertiesParametersTypes);

            // Assert
            parametersOfSetAllOrAnyProperties.ShouldNotBeNull();
            parametersOfSetAllOrAnyProperties.Length.ShouldBe(1);
            methodSetAllOrAnyPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAllOrAnyProperties);
            var methodSetAllOrAnyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetAllOrAnyProperties, methodSetAllOrAnyPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetAllOrAnyPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAllOrAnyProperties);
            var methodSetAllOrAnyPropertiesParametersTypes = new Type[] { typeof(ILboObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetAllOrAnyProperties, methodSetAllOrAnyPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetAllOrAnyPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAllOrAnyProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetAllOrAnyProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetAllOrAnyProperties) (Return Type : IList<ILboProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_SetAllOrAnyProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAllOrAnyProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetAllOrAnyProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetRawParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetRawParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRawParameter, methodGetRawParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var lboObjectName = this.CreateType<string>();
            var rawParam = this.CreateType<string>();
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string) };
            object[] parametersOfGetRawParameter = { onyxUserContext, lboObjectName, rawParam };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRawParameter, methodGetRawParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetRawParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRawParameter.ShouldNotBeNull();
            parametersOfGetRawParameter.Length.ShouldBe(3);
            methodGetRawParameterParametersTypes.Length.ShouldBe(3);
            methodGetRawParameterParametersTypes.Length.ShouldBe(parametersOfGetRawParameter.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var lboObjectName = this.CreateType<string>();
            var rawParam = this.CreateType<string>();
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string) };
            object[] parametersOfGetRawParameter = { onyxUserContext, lboObjectName, rawParam };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetRawParameter, parametersOfGetRawParameter, methodGetRawParameterParametersTypes);

            // Assert
            parametersOfGetRawParameter.ShouldNotBeNull();
            parametersOfGetRawParameter.Length.ShouldBe(3);
            methodGetRawParameterParametersTypes.Length.ShouldBe(3);
            methodGetRawParameterParametersTypes.Length.ShouldBe(parametersOfGetRawParameter.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRawParameter, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRawParameter, methodGetRawParameterParametersTypes);

            // Assert
            methodGetRawParameterParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRawParameter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetRowsetProperties_Method_Call_Internally(Type[] types)
        {
            var methodGetRowsetPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRowsetProperties, methodGetRowsetPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRowsetProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsetProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetRowsetPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetRowsetProperties = { onyxUserContext };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsetProperties, methodGetRowsetPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<string>>(_lboParameterInstanceFixture, out exception1, parametersOfGetRowsetProperties);
            var result2 = this.GetResultOfMethod<List<string>>(MethodGetRowsetProperties, parametersOfGetRowsetProperties, methodGetRowsetPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRowsetProperties.ShouldNotBeNull();
            parametersOfGetRowsetProperties.Length.ShouldBe(1);
            methodGetRowsetPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRowsetProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsetProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetRowsetPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetRowsetProperties = { onyxUserContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsetProperties, methodGetRowsetPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetRowsetProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRowsetProperties.ShouldNotBeNull();
            parametersOfGetRowsetProperties.Length.ShouldBe(1);
            methodGetRowsetPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRowsetProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsetProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetRowsetPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetRowsetProperties = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<string>>(MethodGetRowsetProperties, parametersOfGetRowsetProperties, methodGetRowsetPropertiesParametersTypes);

            // Assert
            parametersOfGetRowsetProperties.ShouldNotBeNull();
            parametersOfGetRowsetProperties.Length.ShouldBe(1);
            methodGetRowsetPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRowsetProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsetProperties);
            var methodGetRowsetPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRowsetProperties, methodGetRowsetPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRowsetPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRowsetProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsetProperties);
            var methodGetRowsetPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRowsetProperties, methodGetRowsetPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRowsetPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRowsetProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsetProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRowsetProperties) (Return Type : List<string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRowsetProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsetProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetRawParameter_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetRawParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRawParameter, methodGetRawParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetRawParameter = { onyxUserContext };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRawParameter, methodGetRawParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboParameterInstanceFixture, out exception1, parametersOfGetRawParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetRawParameter, parametersOfGetRawParameter, methodGetRawParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRawParameter.ShouldNotBeNull();
            parametersOfGetRawParameter.Length.ShouldBe(1);
            methodGetRawParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetRawParameter = { onyxUserContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRawParameter, methodGetRawParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetRawParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRawParameter.ShouldNotBeNull();
            parametersOfGetRawParameter.Length.ShouldBe(1);
            methodGetRawParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetRawParameter = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRawParameter, parametersOfGetRawParameter, methodGetRawParameterParametersTypes);

            // Assert
            parametersOfGetRawParameter.ShouldNotBeNull();
            parametersOfGetRawParameter.Length.ShouldBe(1);
            methodGetRawParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRawParameter, methodGetRawParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRawParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var methodGetRawParameterParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRawParameter, methodGetRawParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRawParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRawParameter, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRawParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetRawParameter_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRawParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRawParameter, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParameter, methodGetParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetParameter_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameter = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var collection = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetParameter = { onyxUserContext, parameter, parameterName, objectType, collection, lboObject };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameter, methodGetParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboParameterInstanceFixture, out exception1, parametersOfGetParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetParameter, parametersOfGetParameter, methodGetParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetParameter.ShouldNotBeNull();
            parametersOfGetParameter.Length.ShouldBe(6);
            methodGetParameterParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetParameter_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameter = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var collection = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetParameter = { onyxUserContext, parameter, parameterName, objectType, collection, lboObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameter, methodGetParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetParameter.ShouldNotBeNull();
            parametersOfGetParameter.Length.ShouldBe(6);
            methodGetParameterParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameter = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var collection = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetParameter = { onyxUserContext, parameter, parameterName, objectType, collection, lboObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetParameter, parametersOfGetParameter, methodGetParameterParametersTypes);

            // Assert
            parametersOfGetParameter.ShouldNotBeNull();
            parametersOfGetParameter.Length.ShouldBe(6);
            methodGetParameterParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetParameter_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameter);
            var methodGetParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParameter, methodGetParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetParameterParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameter);
            var methodGetParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParameter, methodGetParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetParameter_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameter, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetObjectParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectParameter, methodGetObjectParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectParameter_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodType = this.CreateType<string>();
            var methodGetObjectParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject), typeof(string) };
            object[] parametersOfGetObjectParameter = { onyxUserContext, parameterString, parameterName, objectType, lboObject, methodType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectParameter, methodGetObjectParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboParameterInstanceFixture, out exception1, parametersOfGetObjectParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetObjectParameter, parametersOfGetObjectParameter, methodGetObjectParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetObjectParameter.ShouldNotBeNull();
            parametersOfGetObjectParameter.Length.ShouldBe(6);
            methodGetObjectParameterParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectParameter_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodType = this.CreateType<string>();
            var methodGetObjectParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject), typeof(string) };
            object[] parametersOfGetObjectParameter = { onyxUserContext, parameterString, parameterName, objectType, lboObject, methodType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectParameter, methodGetObjectParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetObjectParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetObjectParameter.ShouldNotBeNull();
            parametersOfGetObjectParameter.Length.ShouldBe(6);
            methodGetObjectParameterParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodType = this.CreateType<string>();
            var methodGetObjectParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject), typeof(string) };
            object[] parametersOfGetObjectParameter = { onyxUserContext, parameterString, parameterName, objectType, lboObject, methodType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetObjectParameter, parametersOfGetObjectParameter, methodGetObjectParameterParametersTypes);

            // Assert
            parametersOfGetObjectParameter.ShouldNotBeNull();
            parametersOfGetObjectParameter.Length.ShouldBe(6);
            methodGetObjectParameterParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectParameter_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectParameter);
            var methodGetObjectParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectParameter, methodGetObjectParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetObjectParameterParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectParameter);
            var methodGetObjectParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectParameter, methodGetObjectParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectParameter_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetObjectParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectParameter, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCollectionParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetCollectionParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetCollectionParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCollectionParameter, methodGetCollectionParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetCollectionParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetCollectionParameter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var collection = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetCollectionParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetCollectionParameter = { onyxUserContext, parameterString, parameterName, objectType, collection, lboObject };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCollectionParameter, methodGetCollectionParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboParameterInstanceFixture, parametersOfGetCollectionParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetCollectionParameter, parametersOfGetCollectionParameter, methodGetCollectionParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCollectionParameter.ShouldNotBeNull();
            parametersOfGetCollectionParameter.Length.ShouldBe(6);
            methodGetCollectionParameterParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetCollectionParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetCollectionParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var collection = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetCollectionParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetCollectionParameter = { onyxUserContext, parameterString, parameterName, objectType, collection, lboObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCollectionParameter, parametersOfGetCollectionParameter, methodGetCollectionParameterParametersTypes);

            // Assert
            parametersOfGetCollectionParameter.ShouldNotBeNull();
            parametersOfGetCollectionParameter.Length.ShouldBe(6);
            methodGetCollectionParameterParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCollectionParameter) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetCollectionParameter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionParameter);
            var methodGetCollectionParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCollectionParameter, methodGetCollectionParameterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCollectionParameterParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetCollectionParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetCollectionParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionParameter);
            var methodGetCollectionParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCollectionParameter, methodGetCollectionParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCollectionParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCollectionParameter) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetCollectionParameter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCollectionParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCollectionParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetCollectionParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCollectionParameter, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectInstanceParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectInstanceParameter, methodGetObjectInstanceParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetObjectInstanceParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetObjectInstanceParameter = { onyxUserContext, parameterString, parameterName, objectType, lboObject };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceParameter, methodGetObjectInstanceParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboParameterInstanceFixture, out exception1, parametersOfGetObjectInstanceParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetObjectInstanceParameter, parametersOfGetObjectInstanceParameter, methodGetObjectInstanceParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetObjectInstanceParameter.ShouldNotBeNull();
            parametersOfGetObjectInstanceParameter.Length.ShouldBe(5);
            methodGetObjectInstanceParameterParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetObjectInstanceParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetObjectInstanceParameter = { onyxUserContext, parameterString, parameterName, objectType, lboObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceParameter, methodGetObjectInstanceParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetObjectInstanceParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetObjectInstanceParameter.ShouldNotBeNull();
            parametersOfGetObjectInstanceParameter.Length.ShouldBe(5);
            methodGetObjectInstanceParameterParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceParameter);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var parameterString = this.CreateType<string>();
            var parameterName = this.CreateType<string>();
            var objectType = this.CreateType<string>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetObjectInstanceParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            object[] parametersOfGetObjectInstanceParameter = { onyxUserContext, parameterString, parameterName, objectType, lboObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetObjectInstanceParameter, parametersOfGetObjectInstanceParameter, methodGetObjectInstanceParameterParametersTypes);

            // Assert
            parametersOfGetObjectInstanceParameter.ShouldNotBeNull();
            parametersOfGetObjectInstanceParameter.Length.ShouldBe(5);
            methodGetObjectInstanceParameterParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceParameter);
            var methodGetObjectInstanceParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectInstanceParameter, methodGetObjectInstanceParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetObjectInstanceParameterParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceParameter);
            var methodGetObjectInstanceParameterParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string), typeof(string), typeof(ILboObject) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectInstanceParameter, methodGetObjectInstanceParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectInstanceParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetObjectInstanceParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceParameter, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectInstanceContentPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectInstanceContentProperties, methodGetObjectInstanceContentPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceContentProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetObjectInstanceContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(ILboObject) };
            object[] parametersOfGetObjectInstanceContentProperties = { onyxUserContext, lboObject };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceContentProperties, methodGetObjectInstanceContentPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboProperty>>(_lboParameterInstanceFixture, out exception1, parametersOfGetObjectInstanceContentProperties);
            var result2 = this.GetResultOfMethod<IList<ILboProperty>>(MethodGetObjectInstanceContentProperties, parametersOfGetObjectInstanceContentProperties, methodGetObjectInstanceContentPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetObjectInstanceContentProperties.ShouldNotBeNull();
            parametersOfGetObjectInstanceContentProperties.Length.ShouldBe(2);
            methodGetObjectInstanceContentPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceContentProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetObjectInstanceContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(ILboObject) };
            object[] parametersOfGetObjectInstanceContentProperties = { onyxUserContext, lboObject };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceContentProperties, methodGetObjectInstanceContentPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboParameterInstanceFixture, parametersOfGetObjectInstanceContentProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetObjectInstanceContentProperties.ShouldNotBeNull();
            parametersOfGetObjectInstanceContentProperties.Length.ShouldBe(2);
            methodGetObjectInstanceContentPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceContentProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var lboObject = this.CreateType<ILboObject>();
            var methodGetObjectInstanceContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(ILboObject) };
            object[] parametersOfGetObjectInstanceContentProperties = { onyxUserContext, lboObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboProperty>>(MethodGetObjectInstanceContentProperties, parametersOfGetObjectInstanceContentProperties, methodGetObjectInstanceContentPropertiesParametersTypes);

            // Assert
            parametersOfGetObjectInstanceContentProperties.ShouldNotBeNull();
            parametersOfGetObjectInstanceContentProperties.Length.ShouldBe(2);
            methodGetObjectInstanceContentPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceContentProperties);
            var methodGetObjectInstanceContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(ILboObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectInstanceContentProperties, methodGetObjectInstanceContentPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetObjectInstanceContentPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceContentProperties);
            var methodGetObjectInstanceContentPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(ILboObject) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectInstanceContentProperties, methodGetObjectInstanceContentPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectInstanceContentPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceContentProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceContentProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetObjectInstanceContentProperties) (Return Type : IList<ILboProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboParameter_GetObjectInstanceContentProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstanceContentProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstanceContentProperties, 0);
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