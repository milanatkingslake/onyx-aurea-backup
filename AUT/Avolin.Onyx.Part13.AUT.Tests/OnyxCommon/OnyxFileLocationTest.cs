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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxFileLocation" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxFileLocationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxFileLocation" />)
        /// </summary>
        public OnyxFileLocationTest() : base(typeof(OnyxFileLocation))
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

        #region General Initializer : Class (OnyxFileLocation) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxFileLocationInstanceType;
        private OnyxFileLocation _onyxFileLocationInstance;
        private OnyxFileLocation _onyxFileLocationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxFileLocation" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxFileLocationInstanceType = typeof(OnyxFileLocation);
            _onyxFileLocationInstanceFixture = this.Create<OnyxFileLocation>(false);
            _onyxFileLocationInstance = _onyxFileLocationInstanceFixture ?? this.Create<OnyxFileLocation>(true);
            CurrentInstance = _onyxFileLocationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxFileLocation) Initializer

        #region Properties

        private const string PropertyFileShareAccessMessage = "FileShareAccessMessage";
        private const string PropertyFileShareValid = "FileShareValid";
        private const string PropertyFileShareLocationPath = "FileShareLocationPath";
        private const string PropertyFileShareLocationId = "FileShareLocationId";

        #endregion

        #region Methods

        private const string MethodgetAttachmentFileShare = "getAttachmentFileShare";
        private const string MethodInitAttachmentShareAccess = "InitAttachmentShareAccess";

        #endregion

        #region Fields

        private const string FieldfileShareFound = "fileShareFound";
        private const string FieldfileShareValid = "fileShareValid";
        private const string FieldfileLocationPath = "fileLocationPath";
        private const string FieldfileLocationId = "fileLocationId";
        private const string FieldfileAccessUserMessage = "fileAccessUserMessage";
        private const string FieldinitAttachmentsEvent = "initAttachmentsEvent";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxFileLocation) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxFileLocation_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxFileLocation) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxFileLocation_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxFileLocation) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxFileLocation_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxFileLocation)

        #region General Initializer : Class (OnyxFileLocation) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodgetAttachmentFileShare, 0)]
        [TestCase(MethodInitAttachmentShareAccess, 0)]
        public void AUT_OnyxFileLocation_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxFileLocation) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyFileShareAccessMessage)]
        [TestCase(PropertyFileShareValid)]
        [TestCase(PropertyFileShareLocationPath)]
        [TestCase(PropertyFileShareLocationId)]
        [Category("AUT Property")]
        public void AUT_OnyxFileLocation_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxFileLocation) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldfileShareFound)]
        [TestCase(FieldfileShareValid)]
        [TestCase(FieldfileLocationPath)]
        [TestCase(FieldfileLocationId)]
        [TestCase(FieldfileAccessUserMessage)]
        [TestCase(FieldinitAttachmentsEvent)]
        [Category("AUT Fields")]
        public void AUT_OnyxFileLocation_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxFileLocation) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxFileLocation_Is_Instance_Present_Test()
        {
            // Assert
            _onyxFileLocationInstanceType.ShouldNotBeNull();
            _onyxFileLocationInstance.ShouldNotBeNull();
            _onyxFileLocationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxFileLocation) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxFileLocation" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxFileLocation_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxFileLocationInstance.ShouldBeAssignableTo<OnyxFileLocation>();
            _onyxFileLocationInstanceFixture.ShouldBeAssignableTo<OnyxFileLocation>();
            CurrentInstance.ShouldBeAssignableTo<OnyxFileLocation>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxFileLocation) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxFileLocation_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxFileLocation instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxFileLocation) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyFileShareAccessMessage)]
        [TestCase(PropertyFileShareValid)]
        [TestCase(PropertyFileShareLocationPath)]
        [TestCase(PropertyFileShareLocationId)]
        public void AUT_OnyxFileLocation_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFileLocation) => Property (FileShareAccessMessage) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFileLocation_FileShareAccessMessage_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFileShareAccessMessage);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFileShareAccessMessage);
            Action currentAction = () => propertyInfo.SetValue(_onyxFileLocationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFileLocation) => Property (FileShareAccessMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFileLocation_Public_Class_FileShareAccessMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFileShareAccessMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyFileShareAccessMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFileLocation) => Property (FileShareLocationId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFileLocation_FileShareLocationId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFileShareLocationId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFileShareLocationId);
            Action currentAction = () => propertyInfo.SetValue(_onyxFileLocationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFileLocation) => Property (FileShareLocationId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFileLocation_Public_Class_FileShareLocationId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFileShareLocationId);
            var propertyInfo = this.GetPropertyInfo(PropertyFileShareLocationId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFileLocation) => Property (FileShareLocationPath) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFileLocation_FileShareLocationPath_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFileShareLocationPath);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFileShareLocationPath);
            Action currentAction = () => propertyInfo.SetValue(_onyxFileLocationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFileLocation) => Property (FileShareLocationPath) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFileLocation_Public_Class_FileShareLocationPath_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFileShareLocationPath);
            var propertyInfo = this.GetPropertyInfo(PropertyFileShareLocationPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFileLocation) => Property (FileShareValid) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFileLocation_Public_Class_FileShareValid_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFileShareValid);
            var propertyInfo = this.GetPropertyInfo(PropertyFileShareValid);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (getAttachmentFileShare) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_getAttachmentFileShare_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetAttachmentFileShare);
            Type [] methodgetAttachmentFileShareParametersTypes = null;
            object[] parametersOfgetAttachmentFileShare = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodgetAttachmentFileShare, parametersOfgetAttachmentFileShare, methodgetAttachmentFileShareParametersTypes);

            // Assert
            parametersOfgetAttachmentFileShare.ShouldBeNull();
            methodgetAttachmentFileShareParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getAttachmentFileShare) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_getAttachmentFileShare_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetAttachmentFileShare);
            Type [] methodgetAttachmentFileShareParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetAttachmentFileShare, methodgetAttachmentFileShareParametersTypes);

            // Assert
            methodgetAttachmentFileShareParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getAttachmentFileShare) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_getAttachmentFileShare_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetAttachmentFileShare);
            var currentMethodInfo = this.GetMethodInfo(MethodgetAttachmentFileShare, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitAttachmentShareAccess) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxFileLocation_InitAttachmentShareAccess_Static_Method_Call_Internally(Type[] types)
        {
            var methodInitAttachmentShareAccessParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitAttachmentShareAccess, methodInitAttachmentShareAccessParametersTypes);
        }

        #endregion

        #region Method Call : (InitAttachmentShareAccess) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_InitAttachmentShareAccess_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitAttachmentShareAccess);

            // Act
            Action executeAction = () => OnyxFileLocation.InitAttachmentShareAccess();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InitAttachmentShareAccess) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_InitAttachmentShareAccess_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitAttachmentShareAccess);
            Type [] methodInitAttachmentShareAccessParametersTypes = null;
            object[] parametersOfInitAttachmentShareAccess = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitAttachmentShareAccess, methodInitAttachmentShareAccessParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxFileLocationInstanceFixture, parametersOfInitAttachmentShareAccess);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitAttachmentShareAccess.ShouldBeNull();
            methodInitAttachmentShareAccessParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitAttachmentShareAccess) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_InitAttachmentShareAccess_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitAttachmentShareAccess);
            Type [] methodInitAttachmentShareAccessParametersTypes = null;
            object[] parametersOfInitAttachmentShareAccess = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitAttachmentShareAccess, parametersOfInitAttachmentShareAccess, methodInitAttachmentShareAccessParametersTypes);

            // Assert
            parametersOfInitAttachmentShareAccess.ShouldBeNull();
            methodInitAttachmentShareAccessParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitAttachmentShareAccess) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_InitAttachmentShareAccess_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitAttachmentShareAccess);
            Type [] methodInitAttachmentShareAccessParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitAttachmentShareAccess, methodInitAttachmentShareAccessParametersTypes);

            // Assert
            methodInitAttachmentShareAccessParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitAttachmentShareAccess) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFileLocation_InitAttachmentShareAccess_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitAttachmentShareAccess);
            var currentMethodInfo = this.GetMethodInfo(MethodInitAttachmentShareAccess, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}