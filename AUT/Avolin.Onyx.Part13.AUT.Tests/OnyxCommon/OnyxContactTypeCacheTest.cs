using System;
using System.Collections.Generic;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxContactTypeCache" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxContactTypeCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxContactTypeCache" />)
        /// </summary>
        public OnyxContactTypeCacheTest() : base(typeof(OnyxContactTypeCache))
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

        #region General Initializer : Class (OnyxContactTypeCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxContactTypeCacheInstanceType;
        private OnyxContactTypeCache _onyxContactTypeCacheInstance;
        private OnyxContactTypeCache _onyxContactTypeCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxContactTypeCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxContactTypeCacheInstanceType = typeof(OnyxContactTypeCache);
            _onyxContactTypeCacheInstanceFixture = this.Create<OnyxContactTypeCache>(false);
            _onyxContactTypeCacheInstance = _onyxContactTypeCacheInstanceFixture ?? this.Create<OnyxContactTypeCache>(true);
            CurrentInstance = _onyxContactTypeCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxContactTypeCache) Initializer

        #region Methods

        private const string MethodgetContactTypes = "getContactTypes";
        private const string MethodretrieveCollectionFromOnyx = "retrieveCollectionFromOnyx";

        #endregion

        #region Fields

        private const string FieldcontactTypesDict = "contactTypesDict";
        private const string FieldloadLock = "loadLock";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxContactTypeCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxContactTypeCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxContactTypeCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxContactTypeCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxContactTypeCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxContactTypeCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxContactTypeCache)

        #region General Initializer : Class (OnyxContactTypeCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxContactTypeCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodgetContactTypes, 0)]
        [TestCase(MethodretrieveCollectionFromOnyx, 0)]
        public void AUT_OnyxContactTypeCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxContactTypeCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxContactTypeCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcontactTypesDict)]
        [TestCase(FieldloadLock)]
        [Category("AUT Fields")]
        public void AUT_OnyxContactTypeCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxContactTypeCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxContactTypeCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxContactTypeCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxContactTypeCacheInstance.ShouldBeAssignableTo<OnyxContactTypeCache>();
            _onyxContactTypeCacheInstanceFixture.ShouldBeAssignableTo<OnyxContactTypeCache>();
            CurrentInstance.ShouldBeAssignableTo<OnyxContactTypeCache>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var contactGroupId = this.CreateType<int>();
            var contactCategoryId = this.CreateType<int>();

            // Act
            Action executeAction = () => _onyxContactTypeCacheInstance.getContactTypes(contactGroupId, contactCategoryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var contactGroupId = this.CreateType<int>();
            var contactCategoryId = this.CreateType<int>();
            var returnedValue = default(Dictionary<String, String>);

            // Act
            Action executeAction = () => returnedValue = _onyxContactTypeCacheInstance.getContactTypes(contactGroupId, contactCategoryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var contactGroupId = this.CreateType<int>();
            var contactCategoryId = this.CreateType<int>();
            var methodgetContactTypesParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfgetContactTypes = { contactGroupId, contactCategoryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetContactTypes, methodgetContactTypesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Dictionary<String, String>>(_onyxContactTypeCacheInstanceFixture, parametersOfgetContactTypes);
            var result2 = this.GetResultOfMethod<Dictionary<String, String>>(MethodgetContactTypes, parametersOfgetContactTypes, methodgetContactTypesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetContactTypes.ShouldNotBeNull();
            parametersOfgetContactTypes.Length.ShouldBe(2);
            methodgetContactTypesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var contactGroupId = this.CreateType<int>();
            var contactCategoryId = this.CreateType<int>();
            var methodgetContactTypesParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfgetContactTypes = { contactGroupId, contactCategoryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Dictionary<String, String>>(MethodgetContactTypes, parametersOfgetContactTypes, methodgetContactTypesParametersTypes);

            // Assert
            parametersOfgetContactTypes.ShouldNotBeNull();
            parametersOfgetContactTypes.Length.ShouldBe(2);
            methodgetContactTypesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var methodgetContactTypesParametersTypes = new Type[] { typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetContactTypes, methodgetContactTypesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetContactTypesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var methodgetContactTypesParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetContactTypes, methodgetContactTypesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetContactTypesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var currentMethodInfo = this.GetMethodInfo(MethodgetContactTypes, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getContactTypes) (Return Type : Dictionary<String, String>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_getContactTypes_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetContactTypes);
            var currentMethodInfo = this.GetMethodInfo(MethodgetContactTypes, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (retrieveCollectionFromOnyx) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContactTypeCache_retrieveCollectionFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodretrieveCollectionFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodretrieveCollectionFromOnyx, methodretrieveCollectionFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (retrieveCollectionFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_retrieveCollectionFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveCollectionFromOnyx);
            Type [] methodretrieveCollectionFromOnyxParametersTypes = null;
            object[] parametersOfretrieveCollectionFromOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveCollectionFromOnyx, methodretrieveCollectionFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxContactTypeCacheInstanceFixture, parametersOfretrieveCollectionFromOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodretrieveCollectionFromOnyx, parametersOfretrieveCollectionFromOnyx, methodretrieveCollectionFromOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfretrieveCollectionFromOnyx.ShouldBeNull();
            methodretrieveCollectionFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveCollectionFromOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_retrieveCollectionFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveCollectionFromOnyx);
            Type [] methodretrieveCollectionFromOnyxParametersTypes = null;
            object[] parametersOfretrieveCollectionFromOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodretrieveCollectionFromOnyx, parametersOfretrieveCollectionFromOnyx, methodretrieveCollectionFromOnyxParametersTypes);

            // Assert
            parametersOfretrieveCollectionFromOnyx.ShouldBeNull();
            methodretrieveCollectionFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveCollectionFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_retrieveCollectionFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveCollectionFromOnyx);
            Type [] methodretrieveCollectionFromOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodretrieveCollectionFromOnyx, methodretrieveCollectionFromOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodretrieveCollectionFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveCollectionFromOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_retrieveCollectionFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveCollectionFromOnyx);
            Type [] methodretrieveCollectionFromOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveCollectionFromOnyx, methodretrieveCollectionFromOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveCollectionFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveCollectionFromOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContactTypeCache_retrieveCollectionFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveCollectionFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveCollectionFromOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}