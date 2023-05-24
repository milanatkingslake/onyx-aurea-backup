using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.LboPropertyMapViewModel" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboPropertyMapViewModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboPropertyMapViewModel" />)
        /// </summary>
        public LboPropertyMapViewModelTest() : base(typeof(LboPropertyMapViewModel))
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

        #region General Initializer : Class (LboPropertyMapViewModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboPropertyMapViewModelInstanceType;
        private LboPropertyMapViewModel _lboPropertyMapViewModelInstance;
        private LboPropertyMapViewModel _lboPropertyMapViewModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboPropertyMapViewModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboPropertyMapViewModelInstanceType = typeof(LboPropertyMapViewModel);
            _lboPropertyMapViewModelInstanceFixture = this.Create<LboPropertyMapViewModel>(false);
            _lboPropertyMapViewModelInstance = _lboPropertyMapViewModelInstanceFixture ?? this.Create<LboPropertyMapViewModel>(true);
            CurrentInstance = _lboPropertyMapViewModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboPropertyMapViewModel) Initializer

        #region Methods

        private const string MethodInstance = "Instance";
        private const string MethodAddMappingToCache = "AddMappingToCache";
        private const string MethodGetSaveCollectionFormat = "GetSaveCollectionFormat";
        private const string MethodGetUpdateFormat = "GetUpdateFormat";
        private const string MethodCreateElementNode = "CreateElementNode";
        private const string MethodGetElement = "GetElement";
        private const string MethodAddAttribute = "AddAttribute";
        private const string MethodGetModelMap = "GetModelMap";
        private const string MethodGetElementNode = "GetElementNode";
        private const string MethodValidateXmlAndRemove = "ValidateXmlAndRemove";
        private const string MethodGetAllFieldMapsFromSameLevel = "GetAllFieldMapsFromSameLevel";
        private const string MethodConstructPropertyPath = "ConstructPropertyPath";

        #endregion

        #region Fields

        private const string FieldlboPropertyVm = "lboPropertyVm";
        private const string Fieldmappings = "mappings";

        #endregion

        #endregion

        #region General Initializer : Class (LboPropertyMapViewModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboPropertyMapViewModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboPropertyMapViewModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboPropertyMapViewModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboPropertyMapViewModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboPropertyMapViewModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboPropertyMapViewModel)

        #region General Initializer : Class (LboPropertyMapViewModel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboPropertyMapViewModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInstance, 0)]
        [TestCase(MethodAddMappingToCache, 0)]
        [TestCase(MethodGetSaveCollectionFormat, 0)]
        [TestCase(MethodGetUpdateFormat, 0)]
        [TestCase(MethodCreateElementNode, 0)]
        [TestCase(MethodGetElement, 0)]
        [TestCase(MethodAddAttribute, 0)]
        [TestCase(MethodGetModelMap, 0)]
        [TestCase(MethodGetElementNode, 0)]
        [TestCase(MethodValidateXmlAndRemove, 0)]
        [TestCase(MethodGetAllFieldMapsFromSameLevel, 0)]
        [TestCase(MethodConstructPropertyPath, 0)]
        public void AUT_LboPropertyMapViewModel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LboPropertyMapViewModel) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboPropertyMapViewModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldlboPropertyVm)]
        [TestCase(Fieldmappings)]
        [Category("AUT Fields")]
        public void AUT_LboPropertyMapViewModel_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboPropertyMapViewModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboPropertyMapViewModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboPropertyMapViewModel_Is_Instance_Present_Test()
        {
            // Assert
            _lboPropertyMapViewModelInstanceType.ShouldNotBeNull();
            _lboPropertyMapViewModelInstance.ShouldNotBeNull();
            _lboPropertyMapViewModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (LboPropertyMapViewModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboPropertyMapViewModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboPropertyMapViewModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboPropertyMapViewModelInstance.ShouldBeAssignableTo<LboPropertyMapViewModel>();
            _lboPropertyMapViewModelInstanceFixture.ShouldBeAssignableTo<LboPropertyMapViewModel>();
            CurrentInstance.ShouldBeAssignableTo<LboPropertyMapViewModel>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);

            // Act
            Action executeAction = () => LboPropertyMapViewModel.Instance();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);
            var returnedValue = default(LboPropertyMapViewModel);

            // Act
            Action executeAction = () => returnedValue = LboPropertyMapViewModel.Instance();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);
            Type [] methodInstanceParametersTypes = null;
            object[] parametersOfInstance = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInstance, methodInstanceParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodInstance, methodInstanceParametersTypes);
            var result2 = this.GetResultOfMethod<LboPropertyMapViewModel>(MethodInstance, parametersOfInstance, methodInstanceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfInstance.ShouldBeNull();
            methodInstanceParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<LboPropertyMapViewModel>(MethodInstance, parametersOfInstance, methodInstanceParametersTypes));
        }

        #endregion

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);
            Type [] methodInstanceParametersTypes = null;
            object[] parametersOfInstance = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInstance, methodInstanceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfInstance);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInstance.ShouldBeNull();
            methodInstanceParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);
            Type [] methodInstanceParametersTypes = null;
            object[] parametersOfInstance = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<LboPropertyMapViewModel>(MethodInstance, parametersOfInstance, methodInstanceParametersTypes);

            // Assert
            parametersOfInstance.ShouldBeNull();
            methodInstanceParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);
            Type [] methodInstanceParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInstance, methodInstanceParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodInstanceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);
            Type [] methodInstanceParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInstance, methodInstanceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInstanceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Instance) (Return Type : LboPropertyMapViewModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_Instance_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodInstance, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_Internally(Type[] types)
        {
            var methodAddMappingToCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddMappingToCache, methodAddMappingToCacheParametersTypes);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var model = this.CreateType<MappingsModel>();

            // Act
            Action executeAction = () => _lboPropertyMapViewModelInstance.AddMappingToCache(model);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var model = this.CreateType<MappingsModel>();
            var methodAddMappingToCacheParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfAddMappingToCache = { model };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddMappingToCache, methodAddMappingToCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_lboPropertyMapViewModelInstanceFixture, parametersOfAddMappingToCache);
            var result2 = this.GetResultOfMethod<bool>(MethodAddMappingToCache, parametersOfAddMappingToCache, methodAddMappingToCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddMappingToCache.ShouldNotBeNull();
            parametersOfAddMappingToCache.Length.ShouldBe(1);
            methodAddMappingToCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var model = this.CreateType<MappingsModel>();
            var methodAddMappingToCacheParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfAddMappingToCache = { model };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAddMappingToCache, methodAddMappingToCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_lboPropertyMapViewModelInstanceFixture, out exception1, parametersOfAddMappingToCache);
            var result2 = this.GetResultOfMethod<bool>(MethodAddMappingToCache, parametersOfAddMappingToCache, methodAddMappingToCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAddMappingToCache.ShouldNotBeNull();
            parametersOfAddMappingToCache.Length.ShouldBe(1);
            methodAddMappingToCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var model = this.CreateType<MappingsModel>();
            var methodAddMappingToCacheParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfAddMappingToCache = { model };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddMappingToCache, methodAddMappingToCacheParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfAddMappingToCache);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddMappingToCache.ShouldNotBeNull();
            parametersOfAddMappingToCache.Length.ShouldBe(1);
            methodAddMappingToCacheParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var model = this.CreateType<MappingsModel>();
            var methodAddMappingToCacheParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfAddMappingToCache = { model };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodAddMappingToCache, parametersOfAddMappingToCache, methodAddMappingToCacheParametersTypes);

            // Assert
            parametersOfAddMappingToCache.ShouldNotBeNull();
            parametersOfAddMappingToCache.Length.ShouldBe(1);
            methodAddMappingToCacheParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var methodAddMappingToCacheParametersTypes = new Type[] { typeof(MappingsModel) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddMappingToCache, methodAddMappingToCacheParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddMappingToCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var methodAddMappingToCacheParametersTypes = new Type[] { typeof(MappingsModel) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddMappingToCache, methodAddMappingToCacheParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddMappingToCacheParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var methodAddMappingToCacheParametersTypes = new Type[] { typeof(MappingsModel) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddMappingToCache, methodAddMappingToCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddMappingToCacheParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var currentMethodInfo = this.GetMethodInfo(MethodAddMappingToCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AddMappingToCache) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddMappingToCache_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddMappingToCache);
            var currentMethodInfo = this.GetMethodInfo(MethodAddMappingToCache, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_Internally(Type[] types)
        {
            var methodGetSaveCollectionFormatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSaveCollectionFormat, methodGetSaveCollectionFormatParametersTypes);
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveCollectionFormat);
            var model = this.CreateType<MappingsModel>();
            var methodGetSaveCollectionFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfGetSaveCollectionFormat = { model };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSaveCollectionFormat, methodGetSaveCollectionFormatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_lboPropertyMapViewModelInstanceFixture, out exception1, parametersOfGetSaveCollectionFormat);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetSaveCollectionFormat, parametersOfGetSaveCollectionFormat, methodGetSaveCollectionFormatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetSaveCollectionFormat.ShouldNotBeNull();
            parametersOfGetSaveCollectionFormat.Length.ShouldBe(1);
            methodGetSaveCollectionFormatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveCollectionFormat);
            var model = this.CreateType<MappingsModel>();
            var methodGetSaveCollectionFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfGetSaveCollectionFormat = { model };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSaveCollectionFormat, methodGetSaveCollectionFormatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfGetSaveCollectionFormat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSaveCollectionFormat.ShouldNotBeNull();
            parametersOfGetSaveCollectionFormat.Length.ShouldBe(1);
            methodGetSaveCollectionFormatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveCollectionFormat);
            var model = this.CreateType<MappingsModel>();
            var methodGetSaveCollectionFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfGetSaveCollectionFormat = { model };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetSaveCollectionFormat, parametersOfGetSaveCollectionFormat, methodGetSaveCollectionFormatParametersTypes);

            // Assert
            parametersOfGetSaveCollectionFormat.ShouldNotBeNull();
            parametersOfGetSaveCollectionFormat.Length.ShouldBe(1);
            methodGetSaveCollectionFormatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveCollectionFormat);
            var methodGetSaveCollectionFormatParametersTypes = new Type[] { typeof(MappingsModel) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSaveCollectionFormat, methodGetSaveCollectionFormatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetSaveCollectionFormatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveCollectionFormat);
            var methodGetSaveCollectionFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSaveCollectionFormat, methodGetSaveCollectionFormatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSaveCollectionFormatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveCollectionFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSaveCollectionFormat, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetSaveCollectionFormat) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetSaveCollectionFormat_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSaveCollectionFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSaveCollectionFormat, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_Internally(Type[] types)
        {
            var methodGetUpdateFormatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUpdateFormat, methodGetUpdateFormatParametersTypes);
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdateFormat);
            var model = this.CreateType<MappingsModel>();
            var methodGetUpdateFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfGetUpdateFormat = { model };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdateFormat, methodGetUpdateFormatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_lboPropertyMapViewModelInstanceFixture, out exception1, parametersOfGetUpdateFormat);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetUpdateFormat, parametersOfGetUpdateFormat, methodGetUpdateFormatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetUpdateFormat.ShouldNotBeNull();
            parametersOfGetUpdateFormat.Length.ShouldBe(1);
            methodGetUpdateFormatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdateFormat);
            var model = this.CreateType<MappingsModel>();
            var methodGetUpdateFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfGetUpdateFormat = { model };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdateFormat, methodGetUpdateFormatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfGetUpdateFormat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetUpdateFormat.ShouldNotBeNull();
            parametersOfGetUpdateFormat.Length.ShouldBe(1);
            methodGetUpdateFormatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdateFormat);
            var model = this.CreateType<MappingsModel>();
            var methodGetUpdateFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            object[] parametersOfGetUpdateFormat = { model };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetUpdateFormat, parametersOfGetUpdateFormat, methodGetUpdateFormatParametersTypes);

            // Assert
            parametersOfGetUpdateFormat.ShouldNotBeNull();
            parametersOfGetUpdateFormat.Length.ShouldBe(1);
            methodGetUpdateFormatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdateFormat);
            var methodGetUpdateFormatParametersTypes = new Type[] { typeof(MappingsModel) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUpdateFormat, methodGetUpdateFormatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetUpdateFormatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdateFormat);
            var methodGetUpdateFormatParametersTypes = new Type[] { typeof(MappingsModel) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUpdateFormat, methodGetUpdateFormatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUpdateFormatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdateFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdateFormat, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetUpdateFormat) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetUpdateFormat_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdateFormat);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdateFormat, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateElementNode) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_CreateElementNode_Method_Call_Internally(Type[] types)
        {
            var methodCreateElementNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateElementNode, methodCreateElementNodeParametersTypes);
        }

        #endregion

        #region Method Call : (CreateElementNode) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_CreateElementNode_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateElementNode);
            var nodeName = this.CreateType<string>();
            var xPath = this.CreateType<string>();
            var element = this.CreateType<XElement>();
            var methodCreateElementNodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(XElement) };
            object[] parametersOfCreateElementNode = { nodeName, xPath, element };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateElementNode, methodCreateElementNodeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfCreateElementNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateElementNode.ShouldNotBeNull();
            parametersOfCreateElementNode.Length.ShouldBe(3);
            methodCreateElementNodeParametersTypes.Length.ShouldBe(3);
            methodCreateElementNodeParametersTypes.Length.ShouldBe(parametersOfCreateElementNode.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateElementNode) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_CreateElementNode_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateElementNode);
            var nodeName = this.CreateType<string>();
            var xPath = this.CreateType<string>();
            var element = this.CreateType<XElement>();
            var methodCreateElementNodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(XElement) };
            object[] parametersOfCreateElementNode = { nodeName, xPath, element };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateElementNode, parametersOfCreateElementNode, methodCreateElementNodeParametersTypes);

            // Assert
            parametersOfCreateElementNode.ShouldNotBeNull();
            parametersOfCreateElementNode.Length.ShouldBe(3);
            methodCreateElementNodeParametersTypes.Length.ShouldBe(3);
            methodCreateElementNodeParametersTypes.Length.ShouldBe(parametersOfCreateElementNode.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateElementNode) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_CreateElementNode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateElementNode);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateElementNode, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateElementNode) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_CreateElementNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateElementNode);
            var methodCreateElementNodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateElementNode, methodCreateElementNodeParametersTypes);

            // Assert
            methodCreateElementNodeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateElementNode) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_CreateElementNode_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateElementNode);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateElementNode, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_GetElement_Method_Call_Internally(Type[] types)
        {
            var methodGetElementParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetElement, methodGetElementParametersTypes);
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElement_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElement);
            var element = this.CreateType<XElement>();
            var nodeName = this.CreateType<string>();
            var methodGetElementParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfGetElement = { element, nodeName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetElement, methodGetElementParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_lboPropertyMapViewModelInstanceFixture, parametersOfGetElement);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetElement, parametersOfGetElement, methodGetElementParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetElement.ShouldNotBeNull();
            parametersOfGetElement.Length.ShouldBe(2);
            methodGetElementParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElement_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElement);
            var element = this.CreateType<XElement>();
            var nodeName = this.CreateType<string>();
            var methodGetElementParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfGetElement = { element, nodeName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetElement, methodGetElementParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfGetElement);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetElement.ShouldNotBeNull();
            parametersOfGetElement.Length.ShouldBe(2);
            methodGetElementParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElement_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElement);
            var element = this.CreateType<XElement>();
            var nodeName = this.CreateType<string>();
            var methodGetElementParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfGetElement = { element, nodeName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetElement, parametersOfGetElement, methodGetElementParametersTypes);

            // Assert
            parametersOfGetElement.ShouldNotBeNull();
            parametersOfGetElement.Length.ShouldBe(2);
            methodGetElementParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElement_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElement);
            var methodGetElementParametersTypes = new Type[] { typeof(XElement), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetElement, methodGetElementParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetElementParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElement_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElement);
            var methodGetElementParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetElement, methodGetElementParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetElementParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElement_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetElement, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetElement) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElement_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetElement, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddAttribute) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_AddAttribute_Method_Call_Internally(Type[] types)
        {
            var methodAddAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddAttribute, methodAddAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (AddAttribute) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddAttribute_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAttribute);
            var name = this.CreateType<string>();
            var value = this.CreateType<string>();
            var node = this.CreateType<XElement>();
            var methodAddAttributeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(XElement) };
            object[] parametersOfAddAttribute = { name, value, node };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddAttribute, methodAddAttributeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfAddAttribute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddAttribute.ShouldNotBeNull();
            parametersOfAddAttribute.Length.ShouldBe(3);
            methodAddAttributeParametersTypes.Length.ShouldBe(3);
            methodAddAttributeParametersTypes.Length.ShouldBe(parametersOfAddAttribute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddAttribute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddAttribute_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAttribute);
            var name = this.CreateType<string>();
            var value = this.CreateType<string>();
            var node = this.CreateType<XElement>();
            var methodAddAttributeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(XElement) };
            object[] parametersOfAddAttribute = { name, value, node };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddAttribute, parametersOfAddAttribute, methodAddAttributeParametersTypes);

            // Assert
            parametersOfAddAttribute.ShouldNotBeNull();
            parametersOfAddAttribute.Length.ShouldBe(3);
            methodAddAttributeParametersTypes.Length.ShouldBe(3);
            methodAddAttributeParametersTypes.Length.ShouldBe(parametersOfAddAttribute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddAttribute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodAddAttribute, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddAttribute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAttribute);
            var methodAddAttributeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddAttribute, methodAddAttributeParametersTypes);

            // Assert
            methodAddAttributeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddAttribute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_AddAttribute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodAddAttribute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_GetModelMap_Method_Call_Internally(Type[] types)
        {
            var methodGetModelMapParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetModelMap, methodGetModelMapParametersTypes);
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var entityName = this.CreateType<string>();

            // Act
            Action executeAction = () => _lboPropertyMapViewModelInstance.GetModelMap(entityName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var entityName = this.CreateType<string>();
            var returnedValue = default(MappingsModel);

            // Act
            Action executeAction = () => returnedValue = _lboPropertyMapViewModelInstance.GetModelMap(entityName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var entityName = this.CreateType<string>();
            var methodGetModelMapParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetModelMap = { entityName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelMap, methodGetModelMapParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<MappingsModel>(_lboPropertyMapViewModelInstanceFixture, parametersOfGetModelMap);
            var result2 = this.GetResultOfMethod<MappingsModel>(MethodGetModelMap, parametersOfGetModelMap, methodGetModelMapParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModelMap.ShouldNotBeNull();
            parametersOfGetModelMap.Length.ShouldBe(1);
            methodGetModelMapParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var entityName = this.CreateType<string>();
            var methodGetModelMapParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetModelMap = { entityName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<MappingsModel>(MethodGetModelMap, parametersOfGetModelMap, methodGetModelMapParametersTypes);

            // Assert
            parametersOfGetModelMap.ShouldNotBeNull();
            parametersOfGetModelMap.Length.ShouldBe(1);
            methodGetModelMapParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var methodGetModelMapParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModelMap, methodGetModelMapParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModelMapParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var methodGetModelMapParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModelMap, methodGetModelMapParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModelMapParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelMap, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModelMap) (Return Type : MappingsModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetModelMap_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModelMap);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModelMap, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetElementNode) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_GetElementNode_Method_Call_Internally(Type[] types)
        {
            var methodGetElementNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetElementNode, methodGetElementNodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetElementNode) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElementNode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementNode);
            var model = this.CreateType<MappingModel>();
            var element = this.CreateType<XElement>();
            var methodGetElementNodeParametersTypes = new Type[] { typeof(MappingModel), typeof(XElement) };
            object[] parametersOfGetElementNode = { model, element };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetElementNode, methodGetElementNodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_lboPropertyMapViewModelInstanceFixture, parametersOfGetElementNode);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetElementNode, parametersOfGetElementNode, methodGetElementNodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetElementNode.ShouldNotBeNull();
            parametersOfGetElementNode.Length.ShouldBe(2);
            methodGetElementNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetElementNode) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElementNode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementNode);
            var model = this.CreateType<MappingModel>();
            var element = this.CreateType<XElement>();
            var methodGetElementNodeParametersTypes = new Type[] { typeof(MappingModel), typeof(XElement) };
            object[] parametersOfGetElementNode = { model, element };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetElementNode, parametersOfGetElementNode, methodGetElementNodeParametersTypes);

            // Assert
            parametersOfGetElementNode.ShouldNotBeNull();
            parametersOfGetElementNode.Length.ShouldBe(2);
            methodGetElementNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetElementNode) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElementNode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementNode);
            var methodGetElementNodeParametersTypes = new Type[] { typeof(MappingModel), typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetElementNode, methodGetElementNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetElementNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetElementNode) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElementNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementNode);
            var methodGetElementNodeParametersTypes = new Type[] { typeof(MappingModel), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetElementNode, methodGetElementNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetElementNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetElementNode) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElementNode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetElementNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetElementNode) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetElementNode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetElementNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetElementNode, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_Internally(Type[] types)
        {
            var methodValidateXmlAndRemoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateXmlAndRemove, methodValidateXmlAndRemoveParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var targetXml = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _lboPropertyMapViewModelInstance.ValidateXmlAndRemove(targetXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var targetXml = this.CreateType<XElement>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _lboPropertyMapViewModelInstance.ValidateXmlAndRemove(targetXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var targetXml = this.CreateType<XElement>();
            var methodValidateXmlAndRemoveParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateXmlAndRemove = { targetXml };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXmlAndRemove, methodValidateXmlAndRemoveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_lboPropertyMapViewModelInstanceFixture, out exception1, parametersOfValidateXmlAndRemove);
            var result2 = this.GetResultOfMethod<XElement>(MethodValidateXmlAndRemove, parametersOfValidateXmlAndRemove, methodValidateXmlAndRemoveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateXmlAndRemove.ShouldNotBeNull();
            parametersOfValidateXmlAndRemove.Length.ShouldBe(1);
            methodValidateXmlAndRemoveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var targetXml = this.CreateType<XElement>();
            var methodValidateXmlAndRemoveParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateXmlAndRemove = { targetXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXmlAndRemove, methodValidateXmlAndRemoveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfValidateXmlAndRemove);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidateXmlAndRemove.ShouldNotBeNull();
            parametersOfValidateXmlAndRemove.Length.ShouldBe(1);
            methodValidateXmlAndRemoveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var targetXml = this.CreateType<XElement>();
            var methodValidateXmlAndRemoveParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateXmlAndRemove = { targetXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodValidateXmlAndRemove, parametersOfValidateXmlAndRemove, methodValidateXmlAndRemoveParametersTypes);

            // Assert
            parametersOfValidateXmlAndRemove.ShouldNotBeNull();
            parametersOfValidateXmlAndRemove.Length.ShouldBe(1);
            methodValidateXmlAndRemoveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var methodValidateXmlAndRemoveParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateXmlAndRemove, methodValidateXmlAndRemoveParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateXmlAndRemoveParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var methodValidateXmlAndRemoveParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateXmlAndRemove, methodValidateXmlAndRemoveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateXmlAndRemoveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXmlAndRemove, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ValidateXmlAndRemove) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ValidateXmlAndRemove_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateXmlAndRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateXmlAndRemove, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_Call_Internally(Type[] types)
        {
            var methodGetAllFieldMapsFromSameLevelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAllFieldMapsFromSameLevel, methodGetAllFieldMapsFromSameLevelParametersTypes);
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var element = this.CreateType<XElement>();
            var entityName = this.CreateType<string>();

            // Act
            Action executeAction = () => _lboPropertyMapViewModelInstance.GetAllFieldMapsFromSameLevel(element, entityName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var element = this.CreateType<XElement>();
            var entityName = this.CreateType<string>();
            var returnedValue = default(List<MappingModel>);

            // Act
            Action executeAction = () => returnedValue = _lboPropertyMapViewModelInstance.GetAllFieldMapsFromSameLevel(element, entityName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var element = this.CreateType<XElement>();
            var entityName = this.CreateType<string>();
            var methodGetAllFieldMapsFromSameLevelParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfGetAllFieldMapsFromSameLevel = { element, entityName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllFieldMapsFromSameLevel, methodGetAllFieldMapsFromSameLevelParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<MappingModel>>(_lboPropertyMapViewModelInstanceFixture, parametersOfGetAllFieldMapsFromSameLevel);
            var result2 = this.GetResultOfMethod<List<MappingModel>>(MethodGetAllFieldMapsFromSameLevel, parametersOfGetAllFieldMapsFromSameLevel, methodGetAllFieldMapsFromSameLevelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAllFieldMapsFromSameLevel.ShouldNotBeNull();
            parametersOfGetAllFieldMapsFromSameLevel.Length.ShouldBe(2);
            methodGetAllFieldMapsFromSameLevelParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var element = this.CreateType<XElement>();
            var entityName = this.CreateType<string>();
            var methodGetAllFieldMapsFromSameLevelParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfGetAllFieldMapsFromSameLevel = { element, entityName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<MappingModel>>(MethodGetAllFieldMapsFromSameLevel, parametersOfGetAllFieldMapsFromSameLevel, methodGetAllFieldMapsFromSameLevelParametersTypes);

            // Assert
            parametersOfGetAllFieldMapsFromSameLevel.ShouldNotBeNull();
            parametersOfGetAllFieldMapsFromSameLevel.Length.ShouldBe(2);
            methodGetAllFieldMapsFromSameLevelParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var methodGetAllFieldMapsFromSameLevelParametersTypes = new Type[] { typeof(XElement), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAllFieldMapsFromSameLevel, methodGetAllFieldMapsFromSameLevelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAllFieldMapsFromSameLevelParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var methodGetAllFieldMapsFromSameLevelParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAllFieldMapsFromSameLevel, methodGetAllFieldMapsFromSameLevelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAllFieldMapsFromSameLevelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllFieldMapsFromSameLevel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllFieldMapsFromSameLevel) (Return Type : List<MappingModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_GetAllFieldMapsFromSameLevel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFieldMapsFromSameLevel);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllFieldMapsFromSameLevel, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_Internally(Type[] types)
        {
            var methodConstructPropertyPathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructPropertyPath, methodConstructPropertyPathParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructPropertyPath);
            var element = this.CreateType<XElement>();
            var methodConstructPropertyPathParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConstructPropertyPath = { element };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructPropertyPath, methodConstructPropertyPathParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboPropertyMapViewModelInstanceFixture, out exception1, parametersOfConstructPropertyPath);
            var result2 = this.GetResultOfMethod<string>(MethodConstructPropertyPath, parametersOfConstructPropertyPath, methodConstructPropertyPathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConstructPropertyPath.ShouldNotBeNull();
            parametersOfConstructPropertyPath.Length.ShouldBe(1);
            methodConstructPropertyPathParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructPropertyPath);
            var element = this.CreateType<XElement>();
            var methodConstructPropertyPathParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConstructPropertyPath = { element };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructPropertyPath, methodConstructPropertyPathParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyMapViewModelInstanceFixture, parametersOfConstructPropertyPath);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConstructPropertyPath.ShouldNotBeNull();
            parametersOfConstructPropertyPath.Length.ShouldBe(1);
            methodConstructPropertyPathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructPropertyPath);
            var element = this.CreateType<XElement>();
            var methodConstructPropertyPathParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConstructPropertyPath = { element };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructPropertyPath, parametersOfConstructPropertyPath, methodConstructPropertyPathParametersTypes);

            // Assert
            parametersOfConstructPropertyPath.ShouldNotBeNull();
            parametersOfConstructPropertyPath.Length.ShouldBe(1);
            methodConstructPropertyPathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructPropertyPath);
            var methodConstructPropertyPathParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructPropertyPath, methodConstructPropertyPathParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConstructPropertyPathParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructPropertyPath);
            var methodConstructPropertyPathParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructPropertyPath, methodConstructPropertyPathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructPropertyPathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructPropertyPath);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructPropertyPath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConstructPropertyPath) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyMapViewModel_ConstructPropertyPath_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructPropertyPath);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructPropertyPath, 0);
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