using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.LboObject" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class LboObjectTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboObject" />)
        /// </summary>
        public LboObjectTest() : base(typeof(LboObject))
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

        #region General Initializer : Class (LboObject) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboObjectInstanceType;
        private LboObject _lboObjectInstance;
        private LboObject _lboObjectInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboObject" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboObjectInstanceType = typeof(LboObject);
            _lboObjectInstanceFixture = this.Create<LboObject>(false);
            _lboObjectInstance = _lboObjectInstanceFixture ?? this.Create<LboObject>(true);
            CurrentInstance = _lboObjectInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboObject) Initializer

        #region Methods

        private const string MethodGetObjectMethods = "GetObjectMethods";
        private const string MethodGetObjectProperties = "GetObjectProperties";
        private const string MethodGetLboObjectKeys = "GetLboObjectKeys";

        #endregion

        #endregion

        #region General Initializer : Class (LboObject) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboObject" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboObject_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboObject) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LboObject" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboObject_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboObject) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboObject" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboObject_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboObject)

        #region General Initializer : Class (LboObject) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboObject" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetObjectMethods, 0)]
        [TestCase(MethodGetObjectProperties, 0)]
        [TestCase(MethodGetLboObjectKeys, 0)]
        public void AUT_LboObject_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (LboObject) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboObject" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboObject_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboObjectInstance.ShouldBeAssignableTo<LboObject>();
            _lboObjectInstanceFixture.ShouldBeAssignableTo<LboObject>();
            CurrentInstance.ShouldBeAssignableTo<LboObject>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetObjectMethods) (Return Type : IList<ILboMethod>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectMethods_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectMethods);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetObjectMethodsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetObjectMethods = { onyxUserContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectMethods, methodGetObjectMethodsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboMethod>>(_lboObjectInstanceFixture, parametersOfGetObjectMethods);
            var result2 = this.GetResultOfMethod<IList<ILboMethod>>(MethodGetObjectMethods, parametersOfGetObjectMethods, methodGetObjectMethodsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectMethods.ShouldNotBeNull();
            parametersOfGetObjectMethods.Length.ShouldBe(1);
            methodGetObjectMethodsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectMethods) (Return Type : IList<ILboMethod>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectMethods_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectMethods);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetObjectMethodsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetObjectMethods = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboMethod>>(MethodGetObjectMethods, parametersOfGetObjectMethods, methodGetObjectMethodsParametersTypes);

            // Assert
            parametersOfGetObjectMethods.ShouldNotBeNull();
            parametersOfGetObjectMethods.Length.ShouldBe(1);
            methodGetObjectMethodsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectMethods) (Return Type : IList<ILboMethod>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectMethods_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectMethods);
            var methodGetObjectMethodsParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectMethods, methodGetObjectMethodsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectMethodsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectMethods) (Return Type : IList<ILboMethod>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectMethods_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectMethods);
            var methodGetObjectMethodsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectMethods, methodGetObjectMethodsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectMethodsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectMethods) (Return Type : IList<ILboMethod>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectMethods_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectMethods);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectMethods, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectMethods) (Return Type : IList<ILboMethod>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectMethods_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectMethods);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectMethods, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectProperties) (Return Type : IList<ILboProperty>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboObject_GetObjectProperties_Method_Call_Internally(Type[] types)
        {
            var methodGetObjectPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetObjectProperties, methodGetObjectPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetObjectProperties) (Return Type : IList<ILboProperty>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetObjectPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetObjectProperties = { onyxUserContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectProperties, methodGetObjectPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboProperty>>(_lboObjectInstanceFixture, parametersOfGetObjectProperties);
            var result2 = this.GetResultOfMethod<IList<ILboProperty>>(MethodGetObjectProperties, parametersOfGetObjectProperties, methodGetObjectPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectProperties.ShouldNotBeNull();
            parametersOfGetObjectProperties.Length.ShouldBe(1);
            methodGetObjectPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectProperties) (Return Type : IList<ILboProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetObjectPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetObjectProperties = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboProperty>>(MethodGetObjectProperties, parametersOfGetObjectProperties, methodGetObjectPropertiesParametersTypes);

            // Assert
            parametersOfGetObjectProperties.ShouldNotBeNull();
            parametersOfGetObjectProperties.Length.ShouldBe(1);
            methodGetObjectPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectProperties) (Return Type : IList<ILboProperty>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectProperties);
            var methodGetObjectPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectProperties, methodGetObjectPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectProperties) (Return Type : IList<ILboProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectProperties);
            var methodGetObjectPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectProperties, methodGetObjectPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectProperties) (Return Type : IList<ILboProperty>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectProperties) (Return Type : IList<ILboProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetObjectProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboObjectKeys) (Return Type : IList<ILboObjectKey>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboObject_GetLboObjectKeys_Method_Call_Internally(Type[] types)
        {
            var methodGetLboObjectKeysParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboObjectKeys, methodGetLboObjectKeysParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboObjectKeys) (Return Type : IList<ILboObjectKey>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetLboObjectKeys_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectKeys);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetLboObjectKeysParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetLboObjectKeys = { onyxUserContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectKeys, methodGetLboObjectKeysParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboObjectKey>>(_lboObjectInstanceFixture, parametersOfGetLboObjectKeys);
            var result2 = this.GetResultOfMethod<IList<ILboObjectKey>>(MethodGetLboObjectKeys, parametersOfGetLboObjectKeys, methodGetLboObjectKeysParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboObjectKeys.ShouldNotBeNull();
            parametersOfGetLboObjectKeys.Length.ShouldBe(1);
            methodGetLboObjectKeysParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObjectKeys) (Return Type : IList<ILboObjectKey>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetLboObjectKeys_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectKeys);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetLboObjectKeysParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetLboObjectKeys = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboObjectKey>>(MethodGetLboObjectKeys, parametersOfGetLboObjectKeys, methodGetLboObjectKeysParametersTypes);

            // Assert
            parametersOfGetLboObjectKeys.ShouldNotBeNull();
            parametersOfGetLboObjectKeys.Length.ShouldBe(1);
            methodGetLboObjectKeysParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboObjectKeys) (Return Type : IList<ILboObjectKey>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetLboObjectKeys_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectKeys);
            var methodGetLboObjectKeysParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboObjectKeys, methodGetLboObjectKeysParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboObjectKeysParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObjectKeys) (Return Type : IList<ILboObjectKey>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetLboObjectKeys_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectKeys);
            var methodGetLboObjectKeysParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboObjectKeys, methodGetLboObjectKeysParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboObjectKeysParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboObjectKeys) (Return Type : IList<ILboObjectKey>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetLboObjectKeys_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectKeys);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectKeys, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObjectKeys) (Return Type : IList<ILboObjectKey>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboObject_GetLboObjectKeys_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectKeys);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectKeys, 0);
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