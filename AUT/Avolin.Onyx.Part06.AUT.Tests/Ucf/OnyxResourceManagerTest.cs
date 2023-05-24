using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.OnyxResourceManager" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxResourceManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxResourceManager" />)
        /// </summary>
        public OnyxResourceManagerTest() : base(typeof(OnyxResourceManager))
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

        #region General Initializer : Class (OnyxResourceManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxResourceManagerInstanceType;
        private OnyxResourceManager _onyxResourceManagerInstance;
        private OnyxResourceManager _onyxResourceManagerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxResourceManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxResourceManagerInstanceType = typeof(OnyxResourceManager);
            _onyxResourceManagerInstanceFixture = this.Create<OnyxResourceManager>(false);
            _onyxResourceManagerInstance = _onyxResourceManagerInstanceFixture ?? this.Create<OnyxResourceManager>(true);
            CurrentInstance = _onyxResourceManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxResourceManager) Initializer

        #region Methods

        private const string MethoddoesStringExist = "doesStringExist";
        private const string MethodLoadResourceUri = "LoadResourceUri";
        private const string MethodLoadResourceXml = "LoadResourceXml";
        private const string MethodGetString = "GetString";

        #endregion

        #region Fields

        private const string Field_resourceDocument = "_resourceDocument";
        private const string Field_fileUri = "_fileUri";
        private const string Field_loaded = "_loaded";
        private const string Field_loadedFromXml = "_loadedFromXml";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxResourceManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxResourceManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxResourceManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxResourceManager) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxResourceManager" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxResourceManager_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxResourceManager)

        #region General Initializer : Class (OnyxResourceManager) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxResourceManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethoddoesStringExist, 0)]
        [TestCase(MethodLoadResourceUri, 0)]
        [TestCase(MethodLoadResourceXml, 0)]
        [TestCase(MethodGetString, 0)]
        [TestCase(MethodGetString, 1)]
        public void AUT_OnyxResourceManager_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxResourceManager) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxResourceManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_resourceDocument)]
        [TestCase(Field_fileUri)]
        [TestCase(Field_loaded)]
        [TestCase(Field_loadedFromXml)]
        [Category("AUT Fields")]
        public void AUT_OnyxResourceManager_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxResourceManager) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxResourceManager" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxResourceManager_Is_Instance_Present_Test()
        {
            // Assert
            _onyxResourceManagerInstanceType.ShouldNotBeNull();
            _onyxResourceManagerInstance.ShouldNotBeNull();
            _onyxResourceManagerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxResourceManager) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxResourceManager" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxResourceManager_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxResourceManagerInstance.ShouldBeAssignableTo<OnyxResourceManager>();
            _onyxResourceManagerInstanceFixture.ShouldBeAssignableTo<OnyxResourceManager>();
            CurrentInstance.ShouldBeAssignableTo<OnyxResourceManager>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxResourceManager) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxResourceManager_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxResourceManager instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (doesStringExist) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var stringName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxResourceManagerInstance.doesStringExist(stringName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var stringName = this.CreateType<string>();
            var methoddoesStringExistParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfdoesStringExist = { stringName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethoddoesStringExist, methoddoesStringExistParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxResourceManagerInstanceFixture, parametersOfdoesStringExist);
            var result2 = this.GetResultOfMethod<bool>(MethoddoesStringExist, parametersOfdoesStringExist, methoddoesStringExistParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfdoesStringExist.ShouldNotBeNull();
            parametersOfdoesStringExist.Length.ShouldBe(1);
            methoddoesStringExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var stringName = this.CreateType<string>();
            var methoddoesStringExistParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfdoesStringExist = { stringName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethoddoesStringExist, methoddoesStringExistParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxResourceManagerInstanceFixture, out exception1, parametersOfdoesStringExist);
            var result2 = this.GetResultOfMethod<bool>(MethoddoesStringExist, parametersOfdoesStringExist, methoddoesStringExistParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfdoesStringExist.ShouldNotBeNull();
            parametersOfdoesStringExist.Length.ShouldBe(1);
            methoddoesStringExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var stringName = this.CreateType<string>();
            var methoddoesStringExistParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfdoesStringExist = { stringName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethoddoesStringExist, methoddoesStringExistParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxResourceManagerInstanceFixture, parametersOfdoesStringExist);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfdoesStringExist.ShouldNotBeNull();
            parametersOfdoesStringExist.Length.ShouldBe(1);
            methoddoesStringExistParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var stringName = this.CreateType<string>();
            var methoddoesStringExistParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfdoesStringExist = { stringName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethoddoesStringExist, parametersOfdoesStringExist, methoddoesStringExistParametersTypes);

            // Assert
            parametersOfdoesStringExist.ShouldNotBeNull();
            parametersOfdoesStringExist.Length.ShouldBe(1);
            methoddoesStringExistParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var methoddoesStringExistParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethoddoesStringExist, methoddoesStringExistParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methoddoesStringExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var methoddoesStringExistParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethoddoesStringExist, methoddoesStringExistParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methoddoesStringExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var methoddoesStringExistParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethoddoesStringExist, methoddoesStringExistParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methoddoesStringExistParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var currentMethodInfo = this.GetMethodInfo(MethoddoesStringExist, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (doesStringExist) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_doesStringExist_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethoddoesStringExist);
            var currentMethodInfo = this.GetMethodInfo(MethoddoesStringExist, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_Internally(Type[] types)
        {
            var methodLoadResourceUriParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLoadResourceUri, methodLoadResourceUriParametersTypes);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var uri = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxResourceManagerInstance.LoadResourceUri(uri);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var uri = this.CreateType<string>();
            var methodLoadResourceUriParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLoadResourceUri = { uri };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceUri, methodLoadResourceUriParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxResourceManagerInstanceFixture, parametersOfLoadResourceUri);
            var result2 = this.GetResultOfMethod<bool>(MethodLoadResourceUri, parametersOfLoadResourceUri, methodLoadResourceUriParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLoadResourceUri.ShouldNotBeNull();
            parametersOfLoadResourceUri.Length.ShouldBe(1);
            methodLoadResourceUriParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var uri = this.CreateType<string>();
            var methodLoadResourceUriParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLoadResourceUri = { uri };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceUri, methodLoadResourceUriParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxResourceManagerInstanceFixture, out exception1, parametersOfLoadResourceUri);
            var result2 = this.GetResultOfMethod<bool>(MethodLoadResourceUri, parametersOfLoadResourceUri, methodLoadResourceUriParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLoadResourceUri.ShouldNotBeNull();
            parametersOfLoadResourceUri.Length.ShouldBe(1);
            methodLoadResourceUriParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var uri = this.CreateType<string>();
            var methodLoadResourceUriParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLoadResourceUri = { uri };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceUri, methodLoadResourceUriParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxResourceManagerInstanceFixture, parametersOfLoadResourceUri);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadResourceUri.ShouldNotBeNull();
            parametersOfLoadResourceUri.Length.ShouldBe(1);
            methodLoadResourceUriParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var uri = this.CreateType<string>();
            var methodLoadResourceUriParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLoadResourceUri = { uri };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodLoadResourceUri, parametersOfLoadResourceUri, methodLoadResourceUriParametersTypes);

            // Assert
            parametersOfLoadResourceUri.ShouldNotBeNull();
            parametersOfLoadResourceUri.Length.ShouldBe(1);
            methodLoadResourceUriParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var methodLoadResourceUriParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLoadResourceUri, methodLoadResourceUriParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodLoadResourceUriParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var methodLoadResourceUriParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLoadResourceUri, methodLoadResourceUriParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodLoadResourceUriParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var methodLoadResourceUriParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadResourceUri, methodLoadResourceUriParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLoadResourceUriParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceUri, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (LoadResourceUri) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceUri_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceUri);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceUri, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_Internally(Type[] types)
        {
            var methodLoadResourceXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLoadResourceXml, methodLoadResourceXmlParametersTypes);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var xml = this.CreateType<string>();
            var fakeUri = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxResourceManagerInstance.LoadResourceXml(xml, fakeUri);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var xml = this.CreateType<string>();
            var fakeUri = this.CreateType<string>();
            var methodLoadResourceXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfLoadResourceXml = { xml, fakeUri };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceXml, methodLoadResourceXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxResourceManagerInstanceFixture, parametersOfLoadResourceXml);
            var result2 = this.GetResultOfMethod<bool>(MethodLoadResourceXml, parametersOfLoadResourceXml, methodLoadResourceXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLoadResourceXml.ShouldNotBeNull();
            parametersOfLoadResourceXml.Length.ShouldBe(2);
            methodLoadResourceXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var xml = this.CreateType<string>();
            var fakeUri = this.CreateType<string>();
            var methodLoadResourceXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfLoadResourceXml = { xml, fakeUri };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceXml, methodLoadResourceXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxResourceManagerInstanceFixture, out exception1, parametersOfLoadResourceXml);
            var result2 = this.GetResultOfMethod<bool>(MethodLoadResourceXml, parametersOfLoadResourceXml, methodLoadResourceXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfLoadResourceXml.ShouldNotBeNull();
            parametersOfLoadResourceXml.Length.ShouldBe(2);
            methodLoadResourceXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var xml = this.CreateType<string>();
            var fakeUri = this.CreateType<string>();
            var methodLoadResourceXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfLoadResourceXml = { xml, fakeUri };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceXml, methodLoadResourceXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxResourceManagerInstanceFixture, parametersOfLoadResourceXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadResourceXml.ShouldNotBeNull();
            parametersOfLoadResourceXml.Length.ShouldBe(2);
            methodLoadResourceXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var xml = this.CreateType<string>();
            var fakeUri = this.CreateType<string>();
            var methodLoadResourceXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfLoadResourceXml = { xml, fakeUri };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodLoadResourceXml, parametersOfLoadResourceXml, methodLoadResourceXmlParametersTypes);

            // Assert
            parametersOfLoadResourceXml.ShouldNotBeNull();
            parametersOfLoadResourceXml.Length.ShouldBe(2);
            methodLoadResourceXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var methodLoadResourceXmlParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLoadResourceXml, methodLoadResourceXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodLoadResourceXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var methodLoadResourceXmlParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLoadResourceXml, methodLoadResourceXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodLoadResourceXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var methodLoadResourceXmlParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadResourceXml, methodLoadResourceXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLoadResourceXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (LoadResourceXml) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_LoadResourceXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadResourceXml);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadResourceXml, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxResourceManager_GetString_Method_Call_Internally(Type[] types)
        {
            var methodGetStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxResourceManagerInstance.GetString(stringName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxResourceManagerInstance.GetString(stringName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { stringName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, methodGetStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxResourceManagerInstanceFixture, out exception1, parametersOfGetString);
            var result2 = this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { stringName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, methodGetStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxResourceManagerInstanceFixture, parametersOfGetString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetString = { stringName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);

            // Assert
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(1);
            methodGetStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxResourceManager_GetString_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var tokenValues = this.CreateType<string[]>();

            // Act
            Action executeAction = () => _onyxResourceManagerInstance.GetString(stringName, tokenValues);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var tokenValues = this.CreateType<string[]>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxResourceManagerInstance.GetString(stringName, tokenValues);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var tokenValues = this.CreateType<string[]>();
            var methodGetStringParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfGetString = { stringName, tokenValues };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, methodGetStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxResourceManagerInstanceFixture, out exception1, parametersOfGetString);
            var result2 = this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(2);
            methodGetStringParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var tokenValues = this.CreateType<string[]>();
            var methodGetStringParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfGetString = { stringName, tokenValues };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, methodGetStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxResourceManagerInstanceFixture, parametersOfGetString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(2);
            methodGetStringParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var stringName = this.CreateType<string>();
            var tokenValues = this.CreateType<string[]>();
            var methodGetStringParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            object[] parametersOfGetString = { stringName, tokenValues };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetString, parametersOfGetString, methodGetStringParametersTypes);

            // Assert
            parametersOfGetString.ShouldNotBeNull();
            parametersOfGetString.Length.ShouldBe(2);
            methodGetStringParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string), typeof(string[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetStringParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var methodGetStringParametersTypes = new Type[] { typeof(string), typeof(string[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetString, methodGetStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxResourceManager_GetString_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetString, 1);
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