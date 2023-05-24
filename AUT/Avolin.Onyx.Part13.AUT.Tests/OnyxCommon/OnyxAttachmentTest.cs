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
using Exception = System.Exception;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxAttachment" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxAttachmentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxAttachment" />)
        /// </summary>
        public OnyxAttachmentTest() : base(typeof(OnyxAttachment))
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

        #region General Initializer : Class (OnyxAttachment) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxAttachmentInstanceType;
        private OnyxAttachment _onyxAttachmentInstance;
        private OnyxAttachment _onyxAttachmentInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxAttachment" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxAttachmentInstanceType = typeof(OnyxAttachment);
            _onyxAttachmentInstanceFixture = this.Create<OnyxAttachment>(false);
            _onyxAttachmentInstance = _onyxAttachmentInstanceFixture ?? this.Create<OnyxAttachment>(true);
            CurrentInstance = _onyxAttachmentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxAttachment) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyIsEmbeddedImage = "IsEmbeddedImage";

        #endregion

        #region Methods

        private const string MethodisAttachmentValid = "isAttachmentValid";
        private const string MethodInsertInOnyx = "InsertInOnyx";
        private const string MethodCreateFileLink = "CreateFileLink";

        #endregion

        #region Fields

        private const string FieldoutlookAttachment = "outlookAttachment";
        private const string FieldprimaryId = "primaryId";
        private const string FieldfileExt = "fileExt";
        
        private const string FieldorgFileName = "orgFileName";
        private const string Fieldtitle = "title";
        private const string FieldphysicalFileGuid = "physicalFileGuid";
        private const string FieldisEmbeddedImage = "isEmbeddedImage";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxAttachment) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxAttachment" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAttachment_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxAttachment) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxAttachment" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAttachment_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxAttachment) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxAttachment" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAttachment_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxAttachment)

        #region General Initializer : Class (OnyxAttachment) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxAttachment" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodisAttachmentValid, 0)]
        [TestCase(MethodInsertInOnyx, 0)]
        [TestCase(MethodCreateFileLink, 0)]
        public void AUT_OnyxAttachment_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxAttachment) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxAttachment" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyIsEmbeddedImage)]
        [Category("AUT Property")]
        public void AUT_OnyxAttachment_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxAttachment) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxAttachment" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldoutlookAttachment)]
        [TestCase(FieldprimaryId)]
        [TestCase(FieldfileExt)]
        [TestCase(FieldorgFileName)]
        [TestCase(Fieldtitle)]
        [TestCase(FieldphysicalFileGuid)]
        [TestCase(FieldisEmbeddedImage)]
        [Category("AUT Fields")]
        public void AUT_OnyxAttachment_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxAttachment) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxAttachment" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxAttachment_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxAttachmentInstance.ShouldBeAssignableTo<OnyxAttachment>();
            _onyxAttachmentInstanceFixture.ShouldBeAssignableTo<OnyxAttachment>();
            CurrentInstance.ShouldBeAssignableTo<OnyxAttachment>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxAttachment) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyIsEmbeddedImage)]
        public void AUT_OnyxAttachment_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxAttachment) => Property (IsEmbeddedImage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAttachment_Public_Class_IsEmbeddedImage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsEmbeddedImage);
            var propertyInfo = this.GetPropertyInfo(PropertyIsEmbeddedImage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAttachment) => Property (PrimaryId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAttachment_PrimaryId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);
            Action currentAction = () => propertyInfo.SetValue(_onyxAttachmentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxAttachment) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxAttachment_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

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

        #region Method Call : (isAttachmentValid) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxAttachment_isAttachmentValid_Method_Call_Internally(Type[] types)
        {
            var methodisAttachmentValidParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodisAttachmentValid, methodisAttachmentValidParametersTypes);
        }

        #endregion

        #region Method Call : (isAttachmentValid) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_isAttachmentValid_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodisAttachmentValid);
            Type [] methodisAttachmentValidParametersTypes = null;
            object[] parametersOfisAttachmentValid = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodisAttachmentValid, methodisAttachmentValidParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxAttachmentInstanceFixture, parametersOfisAttachmentValid);
            var result2 = this.GetResultOfMethod<bool>(MethodisAttachmentValid, parametersOfisAttachmentValid, methodisAttachmentValidParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfisAttachmentValid.ShouldBeNull();
            methodisAttachmentValidParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (isAttachmentValid) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_isAttachmentValid_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodisAttachmentValid);
            Type [] methodisAttachmentValidParametersTypes = null;
            object[] parametersOfisAttachmentValid = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodisAttachmentValid, methodisAttachmentValidParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxAttachmentInstanceFixture, out exception1, parametersOfisAttachmentValid);
            var result2 = this.GetResultOfMethod<bool>(MethodisAttachmentValid, parametersOfisAttachmentValid, methodisAttachmentValidParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfisAttachmentValid.ShouldBeNull();
            methodisAttachmentValidParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (isAttachmentValid) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_isAttachmentValid_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodisAttachmentValid);
            Type [] methodisAttachmentValidParametersTypes = null;
            object[] parametersOfisAttachmentValid = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodisAttachmentValid, parametersOfisAttachmentValid, methodisAttachmentValidParametersTypes);

            // Assert
            parametersOfisAttachmentValid.ShouldBeNull();
            methodisAttachmentValidParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (isAttachmentValid) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_isAttachmentValid_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodisAttachmentValid);
            Type [] methodisAttachmentValidParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodisAttachmentValid, methodisAttachmentValidParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodisAttachmentValidParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (isAttachmentValid) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_isAttachmentValid_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodisAttachmentValid);
            var currentMethodInfo = this.GetMethodInfo(MethodisAttachmentValid, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxAttachment_InsertInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _onyxAttachmentInstance.InsertInOnyx(onyxObject);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxAttachmentInstance.InsertInOnyx(onyxObject);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertInOnyx = { onyxObject };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxAttachmentInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var onyxObject = this.CreateType<OnyxObject>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfInsertInOnyx = { onyxObject };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(1);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInsertInOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(OnyxObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_InsertInOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateFileLink) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxAttachment_CreateFileLink_Method_Call_Internally(Type[] types)
        {
            var methodCreateFileLinkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateFileLink, methodCreateFileLinkParametersTypes);
        }

        #endregion

        #region Method Call : (CreateFileLink) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_CreateFileLink_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileLink);
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxAttachmentInstance.CreateFileLink(ownerId, ownerType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateFileLink) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_CreateFileLink_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileLink);
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var methodCreateFileLinkParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfCreateFileLink = { ownerId, ownerType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFileLink, methodCreateFileLinkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxAttachmentInstanceFixture, parametersOfCreateFileLink);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateFileLink.ShouldNotBeNull();
            parametersOfCreateFileLink.Length.ShouldBe(2);
            methodCreateFileLinkParametersTypes.Length.ShouldBe(2);
            methodCreateFileLinkParametersTypes.Length.ShouldBe(parametersOfCreateFileLink.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateFileLink) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_CreateFileLink_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileLink);
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var methodCreateFileLinkParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfCreateFileLink = { ownerId, ownerType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateFileLink, parametersOfCreateFileLink, methodCreateFileLinkParametersTypes);

            // Assert
            parametersOfCreateFileLink.ShouldNotBeNull();
            parametersOfCreateFileLink.Length.ShouldBe(2);
            methodCreateFileLinkParametersTypes.Length.ShouldBe(2);
            methodCreateFileLinkParametersTypes.Length.ShouldBe(parametersOfCreateFileLink.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFileLink) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_CreateFileLink_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileLink);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFileLink, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateFileLink) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_CreateFileLink_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileLink);
            var methodCreateFileLinkParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateFileLink, methodCreateFileLinkParametersTypes);

            // Assert
            methodCreateFileLinkParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFileLink) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAttachment_CreateFileLink_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileLink);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFileLink, 0);

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