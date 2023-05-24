using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxReferenceLookupCache" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxReferenceLookupCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxReferenceLookupCache" />)
        /// </summary>
        public OnyxReferenceLookupCacheTest() : base(typeof(OnyxReferenceLookupCache))
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

        #region General Initializer : Class (OnyxReferenceLookupCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxReferenceLookupCacheInstanceType;
        private OnyxReferenceLookupCache _onyxReferenceLookupCacheInstance;
        private OnyxReferenceLookupCache _onyxReferenceLookupCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxReferenceLookupCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxReferenceLookupCacheInstanceType = typeof(OnyxReferenceLookupCache);
            _onyxReferenceLookupCacheInstanceFixture = this.Create<OnyxReferenceLookupCache>(false);
            _onyxReferenceLookupCacheInstance = _onyxReferenceLookupCacheInstanceFixture ?? this.Create<OnyxReferenceLookupCache>(true);
            CurrentInstance = _onyxReferenceLookupCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxReferenceLookupCache) Initializer

        #region Methods

        private const string MethodretrieveFromOnyx = "retrieveFromOnyx";
        private const string MethodGetParameterDescription = "GetParameterDescription";

        #endregion

        #region Fields

        private const string FieldrefLookupDict = "refLookupDict";
        private const string FieldloadLock = "loadLock";
        private const string FieldreferenceField = "referenceField";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxReferenceLookupCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxReferenceLookupCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxReferenceLookupCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxReferenceLookupCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxReferenceLookupCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxReferenceLookupCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxReferenceLookupCache)

        #region General Initializer : Class (OnyxReferenceLookupCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxReferenceLookupCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodretrieveFromOnyx, 0)]
        [TestCase(MethodGetParameterDescription, 0)]
        public void AUT_OnyxReferenceLookupCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxReferenceLookupCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxReferenceLookupCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldrefLookupDict)]
        [TestCase(FieldloadLock)]
        [TestCase(FieldreferenceField)]
        [Category("AUT Fields")]
        public void AUT_OnyxReferenceLookupCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxReferenceLookupCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxReferenceLookupCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxReferenceLookupCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxReferenceLookupCacheInstance.ShouldBeAssignableTo<OnyxReferenceLookupCache>();
            _onyxReferenceLookupCacheInstanceFixture.ShouldBeAssignableTo<OnyxReferenceLookupCache>();
            CurrentInstance.ShouldBeAssignableTo<OnyxReferenceLookupCache>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_retrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;
            object[] parametersOfretrieveFromOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxReferenceLookupCacheInstanceFixture, parametersOfretrieveFromOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodretrieveFromOnyx, parametersOfretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfretrieveFromOnyx.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_retrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;
            object[] parametersOfretrieveFromOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodretrieveFromOnyx, parametersOfretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            parametersOfretrieveFromOnyx.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_Call_Internally(Type[] types)
        {
            var methodGetParameterDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParameterDescription, methodGetParameterDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var refParamId = this.CreateType<int>();

            // Act
            Action executeAction = () => _onyxReferenceLookupCacheInstance.GetParameterDescription(refParamId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var refParamId = this.CreateType<int>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxReferenceLookupCacheInstance.GetParameterDescription(refParamId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var refParamId = this.CreateType<int>();
            var methodGetParameterDescriptionParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetParameterDescription = { refParamId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDescription, methodGetParameterDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxReferenceLookupCacheInstanceFixture, parametersOfGetParameterDescription);
            var result2 = this.GetResultOfMethod<String>(MethodGetParameterDescription, parametersOfGetParameterDescription, methodGetParameterDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetParameterDescription.ShouldNotBeNull();
            parametersOfGetParameterDescription.Length.ShouldBe(1);
            methodGetParameterDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var refParamId = this.CreateType<int>();
            var methodGetParameterDescriptionParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetParameterDescription = { refParamId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetParameterDescription, parametersOfGetParameterDescription, methodGetParameterDescriptionParametersTypes);

            // Assert
            parametersOfGetParameterDescription.ShouldNotBeNull();
            parametersOfGetParameterDescription.Length.ShouldBe(1);
            methodGetParameterDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var methodGetParameterDescriptionParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParameterDescription, methodGetParameterDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParameterDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var methodGetParameterDescriptionParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParameterDescription, methodGetParameterDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParameterDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameterDescription) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxReferenceLookupCache_GetParameterDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameterDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameterDescription, 0);
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