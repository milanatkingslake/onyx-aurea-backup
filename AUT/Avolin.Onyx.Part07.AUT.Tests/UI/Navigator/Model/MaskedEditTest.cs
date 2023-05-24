using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.MaskedEdit" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MaskedEditTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MaskedEdit" />)
        /// </summary>
        public MaskedEditTest() : base(typeof(MaskedEdit))
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

        #region General Initializer : Class (MaskedEdit) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _maskedEditInstanceType;
        private MaskedEdit _maskedEditInstance;
        private MaskedEdit _maskedEditInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MaskedEdit" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _maskedEditInstanceType = typeof(MaskedEdit);
            _maskedEditInstanceFixture = this.Create<MaskedEdit>(false);
            _maskedEditInstance = _maskedEditInstanceFixture ?? this.Create<MaskedEdit>(true);
            CurrentInstance = _maskedEditInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MaskedEdit) Initializer

        #region Properties

        private const string PropertyMask = "Mask";
        private const string PropertyText = "Text";
        private const string PropertyFilterText = "FilterText";
        private const string PropertyMaxLength = "MaxLength";
        private const string PropertyPromptCharacter = "PromptCharacter";

        #endregion

        #region Methods

        private const string MethodInitTextMask = "InitTextMask";
        private const string MethodGetDecimalPosition = "GetDecimalPosition";
        private const string MethodGetLeftNextEmptyPosition = "GetLeftNextEmptyPosition";
        private const string MethodLoadText = "LoadText";
        private const string MethodInternalLoadText = "InternalLoadText";
        private const string MethodIsValidUserMask = "IsValidUserMask";
        private const string MethodResolvePartternMask = "ResolvePartternMask";
        private const string MethodGetMaskedText = "GetMaskedText";

        #endregion

        #region Fields

        private const string Field_ValidChar = "_ValidChar";
        private const string Field_ExtendedValidChar = "_ExtendedValidChar";
        private const string Field_DataType = "_DataType";
        private const string Field_EscapeChar = "_EscapeChar";
        private const string Field_EscapeCharForwardSlash = "_EscapeCharForwardSlash";
        private const string Field_ValidModifyChar = "_ValidModifyChar";
        private const string Field_ValidSignalChar = "_ValidSignalChar";
        private const string Field_ValidAMPMChar = "_ValidAMPMChar";
        private const string Field_SpecialChar = "_SpecialChar";
        private const string Field_InputToUpper = "_InputToUpper";
        private const string Field_InputToLower = "_InputToLower";
        private const string Field_ShowSignal = "_ShowSignal";
        private const string Field_ShowAMPM = "_ShowAMPM";
        private const string Field_CursorPosition = "_CursorPosition";
        private const string Field_MaskFormated = "_MaskFormated";
        private const string Field_LastTextMask = "_LastTextMask";
        private const string Field_MaskInternalType = "_MaskInternalType";
        private const string Field_MaskInputChar = "_MaskInputChar";
        private const string Field_MaskTemplate = "_MaskTemplate";
        private const string Field_MaskToApply = "_MaskToApply";
        private const string Field_InputFirstPos = "_InputFirstPos";
        private const string Field_InputLastPos = "_InputLastPos";
        private const string Field_HasDecimalMask = "_HasDecimalMask";
        private const string Field_HasDateSepMask = "_HasDateSepMask";
        private const string Field_HasTimeSepMask = "_HasTimeSepMask";
        private const string Field_keyPreviewValid = "_keyPreviewValid";
        private const string Field_keyPreviewUnknown = "_keyPreviewUnknown";
        private const string Field_ShiftLeftOnDelete = "_ShiftLeftOnDelete";
        private const string Field_Rightbehavior = "_Rightbehavior";
        private const string Field_Loaded = "_Loaded";
        private const string Field_SavedPreview = "_SavedPreview";
        private const string Field_DefaultRightCursorPos = "_DefaultRightCursorPos";
        private const string Field_IsLostFocus = "_IsLostFocus";
        private const string Field_IsFirstPress = "_IsFirstPress";
        private const string Field_IsReadOnly = "_IsReadOnly";
        private const string Field_IsEnabled = "_IsEnabled";
        private const string Field_Prompt = "_Prompt";

        #endregion

        #endregion

        #region General Initializer : Class (MaskedEdit) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MaskedEdit_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MaskedEdit) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MaskedEdit_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MaskedEdit) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MaskedEdit_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MaskedEdit)

        #region General Initializer : Class (MaskedEdit) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitTextMask, 0)]
        [TestCase(MethodGetDecimalPosition, 0)]
        [TestCase(MethodGetLeftNextEmptyPosition, 0)]
        [TestCase(MethodLoadText, 0)]
        [TestCase(MethodInternalLoadText, 0)]
        [TestCase(MethodIsValidUserMask, 0)]
        [TestCase(MethodResolvePartternMask, 0)]
        [TestCase(MethodGetMaskedText, 0)]
        public void AUT_MaskedEdit_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MaskedEdit) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyMask)]
        [TestCase(PropertyText)]
        [TestCase(PropertyFilterText)]
        [TestCase(PropertyMaxLength)]
        [TestCase(PropertyPromptCharacter)]
        [Category("AUT Property")]
        public void AUT_MaskedEdit_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (MaskedEdit) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_ValidChar)]
        [TestCase(Field_ExtendedValidChar)]
        [TestCase(Field_DataType)]
        [TestCase(Field_EscapeChar)]
        [TestCase(Field_EscapeCharForwardSlash)]
        [TestCase(Field_ValidModifyChar)]
        [TestCase(Field_ValidSignalChar)]
        [TestCase(Field_ValidAMPMChar)]
        [TestCase(Field_SpecialChar)]
        [TestCase(Field_InputToUpper)]
        [TestCase(Field_InputToLower)]
        [TestCase(Field_ShowSignal)]
        [TestCase(Field_ShowAMPM)]
        [TestCase(Field_CursorPosition)]
        [TestCase(Field_MaskFormated)]
        [TestCase(Field_LastTextMask)]
        [TestCase(Field_MaskInternalType)]
        [TestCase(Field_MaskInputChar)]
        [TestCase(Field_MaskTemplate)]
        [TestCase(Field_MaskToApply)]
        [TestCase(Field_InputFirstPos)]
        [TestCase(Field_InputLastPos)]
        [TestCase(Field_HasDecimalMask)]
        [TestCase(Field_HasDateSepMask)]
        [TestCase(Field_HasTimeSepMask)]
        [TestCase(Field_keyPreviewValid)]
        [TestCase(Field_keyPreviewUnknown)]
        [TestCase(Field_ShiftLeftOnDelete)]
        [TestCase(Field_Rightbehavior)]
        [TestCase(Field_Loaded)]
        [TestCase(Field_SavedPreview)]
        [TestCase(Field_DefaultRightCursorPos)]
        [TestCase(Field_IsLostFocus)]
        [TestCase(Field_IsFirstPress)]
        [TestCase(Field_IsReadOnly)]
        [TestCase(Field_IsEnabled)]
        [TestCase(Field_Prompt)]
        [Category("AUT Fields")]
        public void AUT_MaskedEdit_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MaskedEdit) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MaskedEdit_Is_Instance_Present_Test()
        {
            // Assert
            _maskedEditInstanceType.ShouldNotBeNull();
            _maskedEditInstance.ShouldNotBeNull();
            _maskedEditInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MaskedEdit) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MaskedEdit" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MaskedEdit_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _maskedEditInstance.ShouldBeAssignableTo<MaskedEdit>();
            _maskedEditInstanceFixture.ShouldBeAssignableTo<MaskedEdit>();
            CurrentInstance.ShouldBeAssignableTo<MaskedEdit>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MaskedEdit) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MaskedEdit_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MaskedEdit instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (MaskedEdit) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MaskedEdit_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var maskedEditInstance  = new MaskedEdit();

            // Asserts
            maskedEditInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MaskedEdit) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyMask)]
        [TestCase(PropertyText)]
        [TestCase(PropertyFilterText)]
        [TestCase(PropertyMaxLength)]
        [TestCase(PropertyPromptCharacter)]
        public void AUT_MaskedEdit_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MaskedEdit) => Property (FilterText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MaskedEdit_Public_Class_FilterText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFilterText);
            var propertyInfo = this.GetPropertyInfo(PropertyFilterText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MaskedEdit) => Property (Mask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MaskedEdit_Public_Class_Mask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMask);
            var propertyInfo = this.GetPropertyInfo(PropertyMask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MaskedEdit) => Property (MaxLength) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MaskedEdit_Public_Class_MaxLength_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMaxLength);
            var propertyInfo = this.GetPropertyInfo(PropertyMaxLength);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MaskedEdit) => Property (PromptCharacter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MaskedEdit_Public_Class_PromptCharacter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPromptCharacter);
            var propertyInfo = this.GetPropertyInfo(PropertyPromptCharacter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MaskedEdit) => Property (Text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MaskedEdit_Public_Class_Text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyText);
            var propertyInfo = this.GetPropertyInfo(PropertyText);

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

        #region Method Call : (InitTextMask) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InitTextMask_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitTextMask);
            Type [] methodInitTextMaskParametersTypes = null;
            object[] parametersOfInitTextMask = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitTextMask, methodInitTextMaskParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_maskedEditInstanceFixture, parametersOfInitTextMask);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitTextMask.ShouldBeNull();
            methodInitTextMaskParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitTextMask) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InitTextMask_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitTextMask);
            Type [] methodInitTextMaskParametersTypes = null;
            object[] parametersOfInitTextMask = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitTextMask, parametersOfInitTextMask, methodInitTextMaskParametersTypes);

            // Assert
            parametersOfInitTextMask.ShouldBeNull();
            methodInitTextMaskParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitTextMask) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InitTextMask_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitTextMask);
            Type [] methodInitTextMaskParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitTextMask, methodInitTextMaskParametersTypes);

            // Assert
            methodInitTextMaskParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitTextMask) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InitTextMask_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitTextMask);
            var currentMethodInfo = this.GetMethodInfo(MethodInitTextMask, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDecimalPosition) (Return Type : int?) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MaskedEdit_GetDecimalPosition_Method_Call_Internally(Type[] types)
        {
            var methodGetDecimalPositionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDecimalPosition, methodGetDecimalPositionParametersTypes);
        }

        #endregion

        #region Method Call : (GetDecimalPosition) (Return Type : int?) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetDecimalPosition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecimalPosition);
            Type [] methodGetDecimalPositionParametersTypes = null;
            object[] parametersOfGetDecimalPosition = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int?>(MethodGetDecimalPosition, parametersOfGetDecimalPosition, methodGetDecimalPositionParametersTypes);

            // Assert
            parametersOfGetDecimalPosition.ShouldBeNull();
            methodGetDecimalPositionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDecimalPosition) (Return Type : int?) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetDecimalPosition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecimalPosition);
            Type [] methodGetDecimalPositionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDecimalPosition, methodGetDecimalPositionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDecimalPositionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDecimalPosition) (Return Type : int?) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetDecimalPosition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecimalPosition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDecimalPosition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLeftNextEmptyPosition) (Return Type : int?) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MaskedEdit_GetLeftNextEmptyPosition_Method_Call_Internally(Type[] types)
        {
            var methodGetLeftNextEmptyPositionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLeftNextEmptyPosition, methodGetLeftNextEmptyPositionParametersTypes);
        }

        #endregion

        #region Method Call : (GetLeftNextEmptyPosition) (Return Type : int?) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetLeftNextEmptyPosition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLeftNextEmptyPosition);
            Type [] methodGetLeftNextEmptyPositionParametersTypes = null;
            object[] parametersOfGetLeftNextEmptyPosition = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<int?>(MethodGetLeftNextEmptyPosition, parametersOfGetLeftNextEmptyPosition, methodGetLeftNextEmptyPositionParametersTypes);

            // Assert
            parametersOfGetLeftNextEmptyPosition.ShouldBeNull();
            methodGetLeftNextEmptyPositionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLeftNextEmptyPosition) (Return Type : int?) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetLeftNextEmptyPosition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLeftNextEmptyPosition);
            Type [] methodGetLeftNextEmptyPositionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLeftNextEmptyPosition, methodGetLeftNextEmptyPositionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLeftNextEmptyPositionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLeftNextEmptyPosition) (Return Type : int?) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetLeftNextEmptyPosition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLeftNextEmptyPosition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLeftNextEmptyPosition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LoadText) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MaskedEdit_LoadText_Method_Call_Internally(Type[] types)
        {
            var methodLoadTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLoadText, methodLoadTextParametersTypes);
        }

        #endregion

        #region Method Call : (LoadText) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_LoadText_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadText);
            var value = this.CreateType<object>();

            // Act
            Action executeAction = () => _maskedEditInstance.LoadText(value);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LoadText) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_LoadText_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadText);
            var value = this.CreateType<object>();
            var methodLoadTextParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfLoadText = { value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadText, methodLoadTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_maskedEditInstanceFixture, parametersOfLoadText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadText.ShouldNotBeNull();
            parametersOfLoadText.Length.ShouldBe(1);
            methodLoadTextParametersTypes.Length.ShouldBe(1);
            methodLoadTextParametersTypes.Length.ShouldBe(parametersOfLoadText.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LoadText) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_LoadText_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadText);
            var value = this.CreateType<object>();
            var methodLoadTextParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfLoadText = { value };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadText, parametersOfLoadText, methodLoadTextParametersTypes);

            // Assert
            parametersOfLoadText.ShouldNotBeNull();
            parametersOfLoadText.Length.ShouldBe(1);
            methodLoadTextParametersTypes.Length.ShouldBe(1);
            methodLoadTextParametersTypes.Length.ShouldBe(parametersOfLoadText.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadText) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_LoadText_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadText);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadText, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadText) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_LoadText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadText);
            var methodLoadTextParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadText, methodLoadTextParametersTypes);

            // Assert
            methodLoadTextParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadText) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_LoadText_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadText);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadText, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InternalLoadText) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MaskedEdit_InternalLoadText_Method_Call_Internally(Type[] types)
        {
            var methodInternalLoadTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInternalLoadText, methodInternalLoadTextParametersTypes);
        }

        #endregion

        #region Method Call : (InternalLoadText) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InternalLoadText_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalLoadText);
            Type [] methodInternalLoadTextParametersTypes = null;
            object[] parametersOfInternalLoadText = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInternalLoadText, methodInternalLoadTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_maskedEditInstanceFixture, parametersOfInternalLoadText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInternalLoadText.ShouldBeNull();
            methodInternalLoadTextParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InternalLoadText) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InternalLoadText_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalLoadText);
            Type [] methodInternalLoadTextParametersTypes = null;
            object[] parametersOfInternalLoadText = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInternalLoadText, parametersOfInternalLoadText, methodInternalLoadTextParametersTypes);

            // Assert
            parametersOfInternalLoadText.ShouldBeNull();
            methodInternalLoadTextParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InternalLoadText) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InternalLoadText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalLoadText);
            Type [] methodInternalLoadTextParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInternalLoadText, methodInternalLoadTextParametersTypes);

            // Assert
            methodInternalLoadTextParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InternalLoadText) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_InternalLoadText_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInternalLoadText);
            var currentMethodInfo = this.GetMethodInfo(MethodInternalLoadText, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsValidUserMask) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MaskedEdit_IsValidUserMask_Method_Call_Internally(Type[] types)
        {
            var methodIsValidUserMaskParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsValidUserMask, methodIsValidUserMaskParametersTypes);
        }

        #endregion

        #region Method Call : (IsValidUserMask) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_IsValidUserMask_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidUserMask);
            Type [] methodIsValidUserMaskParametersTypes = null;
            object[] parametersOfIsValidUserMask = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsValidUserMask, methodIsValidUserMaskParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_maskedEditInstanceFixture, parametersOfIsValidUserMask);
            var result2 = this.GetResultOfMethod<bool>(MethodIsValidUserMask, parametersOfIsValidUserMask, methodIsValidUserMaskParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsValidUserMask.ShouldBeNull();
            methodIsValidUserMaskParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsValidUserMask) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_IsValidUserMask_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidUserMask);
            Type [] methodIsValidUserMaskParametersTypes = null;
            object[] parametersOfIsValidUserMask = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsValidUserMask, methodIsValidUserMaskParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_maskedEditInstanceFixture, out exception1, parametersOfIsValidUserMask);
            var result2 = this.GetResultOfMethod<bool>(MethodIsValidUserMask, parametersOfIsValidUserMask, methodIsValidUserMaskParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsValidUserMask.ShouldBeNull();
            methodIsValidUserMaskParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsValidUserMask) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_IsValidUserMask_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidUserMask);
            Type [] methodIsValidUserMaskParametersTypes = null;
            object[] parametersOfIsValidUserMask = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsValidUserMask, parametersOfIsValidUserMask, methodIsValidUserMaskParametersTypes);

            // Assert
            parametersOfIsValidUserMask.ShouldBeNull();
            methodIsValidUserMaskParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsValidUserMask) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_IsValidUserMask_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidUserMask);
            Type [] methodIsValidUserMaskParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsValidUserMask, methodIsValidUserMaskParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsValidUserMaskParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsValidUserMask) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_IsValidUserMask_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsValidUserMask);
            var currentMethodInfo = this.GetMethodInfo(MethodIsValidUserMask, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolvePartternMask) (Return Type : InputDataType) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MaskedEdit_ResolvePartternMask_Method_Call_Internally(Type[] types)
        {
            var methodResolvePartternMaskParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResolvePartternMask, methodResolvePartternMaskParametersTypes);
        }

        #endregion
        
        #region Method Call : (ResolvePartternMask) (Return Type : InputDataType) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_ResolvePartternMask_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolvePartternMask);
            Type [] methodResolvePartternMaskParametersTypes = null;
            object[] parametersOfResolvePartternMask = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResolvePartternMask, methodResolvePartternMaskParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_maskedEditInstanceFixture, parametersOfResolvePartternMask);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResolvePartternMask.ShouldBeNull();
            methodResolvePartternMaskParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResolvePartternMask) (Return Type : InputDataType) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_ResolvePartternMask_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolvePartternMask);
            Type [] methodResolvePartternMaskParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResolvePartternMask, methodResolvePartternMaskParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodResolvePartternMaskParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolvePartternMask) (Return Type : InputDataType) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_ResolvePartternMask_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolvePartternMask);
            Type [] methodResolvePartternMaskParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResolvePartternMask, methodResolvePartternMaskParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResolvePartternMaskParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResolvePartternMask) (Return Type : InputDataType) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_ResolvePartternMask_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResolvePartternMask);
            var currentMethodInfo = this.GetMethodInfo(MethodResolvePartternMask, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_MaskedEdit_GetMaskedText_Method_Call_Internally(Type[] types)
        {
            var methodGetMaskedTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMaskedText, methodGetMaskedTextParametersTypes);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);

            // Act
            Action executeAction = () => _maskedEditInstance.GetMaskedText();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _maskedEditInstance.GetMaskedText();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            Type [] methodGetMaskedTextParametersTypes = null;
            object[] parametersOfGetMaskedText = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskedText, methodGetMaskedTextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_maskedEditInstanceFixture, parametersOfGetMaskedText);
            var result2 = this.GetResultOfMethod<string>(MethodGetMaskedText, parametersOfGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMaskedText.ShouldBeNull();
            methodGetMaskedTextParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            Type [] methodGetMaskedTextParametersTypes = null;
            object[] parametersOfGetMaskedText = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskedText, methodGetMaskedTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_maskedEditInstanceFixture, parametersOfGetMaskedText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMaskedText.ShouldBeNull();
            methodGetMaskedTextParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            Type [] methodGetMaskedTextParametersTypes = null;
            object[] parametersOfGetMaskedText = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMaskedText, parametersOfGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            parametersOfGetMaskedText.ShouldBeNull();
            methodGetMaskedTextParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            Type [] methodGetMaskedTextParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMaskedTextParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            Type [] methodGetMaskedTextParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMaskedText, methodGetMaskedTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMaskedTextParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMaskedText) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_MaskedEdit_GetMaskedText_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaskedText);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaskedText, 0);

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