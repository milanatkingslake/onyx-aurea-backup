using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage.ModelDescriptions;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage.ModelDescriptions
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions.ModelDescriptionGenerator" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ModelDescriptionGeneratorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ModelDescriptionGenerator" />)
        /// </summary>
        public ModelDescriptionGeneratorTest() : base(typeof(ModelDescriptionGenerator))
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

        #region General Initializer : Class (ModelDescriptionGenerator) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _modelDescriptionGeneratorInstanceType;
        private ModelDescriptionGenerator _modelDescriptionGeneratorInstance;
        private ModelDescriptionGenerator _modelDescriptionGeneratorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ModelDescriptionGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _modelDescriptionGeneratorInstanceType = typeof(ModelDescriptionGenerator);
            _modelDescriptionGeneratorInstanceFixture = this.Create<ModelDescriptionGenerator>(false);
            _modelDescriptionGeneratorInstance = _modelDescriptionGeneratorInstanceFixture ?? this.Create<ModelDescriptionGenerator>(true);
            CurrentInstance = _modelDescriptionGeneratorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ModelDescriptionGenerator) Initializer

        #region Properties

        private const string PropertyGeneratedModels = "GeneratedModels";
        private const string PropertyDocumentationProvider = "DocumentationProvider";

        #endregion

        #region Methods

        private const string MethodGetOrCreateModelDescription = "GetOrCreateModelDescription";
        private const string MethodGetMemberName = "GetMemberName";
        private const string MethodShouldDisplayMember = "ShouldDisplayMember";
        private const string MethodCreateDefaultDocumentation = "CreateDefaultDocumentation";
        private const string MethodGenerateAnnotations = "GenerateAnnotations";
        private const string MethodGenerateCollectionModelDescription = "GenerateCollectionModelDescription";
        private const string MethodGenerateComplexTypeModelDescription = "GenerateComplexTypeModelDescription";
        private const string MethodGenerateDictionaryModelDescription = "GenerateDictionaryModelDescription";
        private const string MethodGenerateEnumTypeModelDescription = "GenerateEnumTypeModelDescription";
        private const string MethodGenerateKeyValuePairModelDescription = "GenerateKeyValuePairModelDescription";
        private const string MethodGenerateSimpleTypeModelDescription = "GenerateSimpleTypeModelDescription";

        #endregion

        #region Fields

        private const string FieldAnnotationTextGenerator = "AnnotationTextGenerator";
        private const string FieldDefaultTypeDocumentation = "DefaultTypeDocumentation";
        private const string Field_documentationProvider = "_documentationProvider";

        #endregion

        #endregion

        #region General Initializer : Class (ModelDescriptionGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ModelDescriptionGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModelDescriptionGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelDescriptionGenerator) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ModelDescriptionGenerator" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModelDescriptionGenerator_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelDescriptionGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ModelDescriptionGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModelDescriptionGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ModelDescriptionGenerator)

        #region General Initializer : Class (ModelDescriptionGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ModelDescriptionGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetOrCreateModelDescription, 0)]
        [TestCase(MethodGetMemberName, 0)]
        [TestCase(MethodShouldDisplayMember, 0)]
        [TestCase(MethodCreateDefaultDocumentation, 0)]
        [TestCase(MethodGenerateAnnotations, 0)]
        [TestCase(MethodGenerateCollectionModelDescription, 0)]
        [TestCase(MethodGenerateComplexTypeModelDescription, 0)]
        [TestCase(MethodGenerateDictionaryModelDescription, 0)]
        [TestCase(MethodGenerateEnumTypeModelDescription, 0)]
        [TestCase(MethodGenerateKeyValuePairModelDescription, 0)]
        [TestCase(MethodGenerateSimpleTypeModelDescription, 0)]
        public void AUT_ModelDescriptionGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ModelDescriptionGenerator) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ModelDescriptionGenerator" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyGeneratedModels)]
        [TestCase(PropertyDocumentationProvider)]
        [Category("AUT Property")]
        public void AUT_ModelDescriptionGenerator_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ModelDescriptionGenerator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ModelDescriptionGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldAnnotationTextGenerator)]
        [TestCase(FieldDefaultTypeDocumentation)]
        [TestCase(Field_documentationProvider)]
        [Category("AUT Fields")]
        public void AUT_ModelDescriptionGenerator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ModelDescriptionGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ModelDescriptionGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ModelDescriptionGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _modelDescriptionGeneratorInstance.ShouldBeAssignableTo<ModelDescriptionGenerator>();
            _modelDescriptionGeneratorInstanceFixture.ShouldBeAssignableTo<ModelDescriptionGenerator>();
            CurrentInstance.ShouldBeAssignableTo<ModelDescriptionGenerator>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ModelDescriptionGenerator) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyGeneratedModels)]
        [TestCase(PropertyDocumentationProvider)]
        public void AUT_ModelDescriptionGenerator_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ModelDescriptionGenerator) => Property (DocumentationProvider) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModelDescriptionGenerator_DocumentationProvider_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDocumentationProvider);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDocumentationProvider);
            Action currentAction = () => propertyInfo.SetValue(_modelDescriptionGeneratorInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ModelDescriptionGenerator) => Property (DocumentationProvider) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModelDescriptionGenerator_Public_Class_DocumentationProvider_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDocumentationProvider);
            var propertyInfo = this.GetPropertyInfo(PropertyDocumentationProvider);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ModelDescriptionGenerator) => Property (GeneratedModels) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModelDescriptionGenerator_Public_Class_GeneratedModels_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGeneratedModels);
            var propertyInfo = this.GetPropertyInfo(PropertyGeneratedModels);

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

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var modelType = this.CreateType<Type>();

            // Act
            Action executeAction = () => _modelDescriptionGeneratorInstance.GetOrCreateModelDescription(modelType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var modelType = this.CreateType<Type>();
            var returnedValue = default(ModelDescription);

            // Act
            Action executeAction = () => returnedValue = _modelDescriptionGeneratorInstance.GetOrCreateModelDescription(modelType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGetOrCreateModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetOrCreateModelDescription = { modelType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateModelDescription, methodGetOrCreateModelDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ModelDescription>(_modelDescriptionGeneratorInstanceFixture, parametersOfGetOrCreateModelDescription);
            var result2 = this.GetResultOfMethod<ModelDescription>(MethodGetOrCreateModelDescription, parametersOfGetOrCreateModelDescription, methodGetOrCreateModelDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOrCreateModelDescription.ShouldNotBeNull();
            parametersOfGetOrCreateModelDescription.Length.ShouldBe(1);
            methodGetOrCreateModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGetOrCreateModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetOrCreateModelDescription = { modelType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelDescription>(MethodGetOrCreateModelDescription, parametersOfGetOrCreateModelDescription, methodGetOrCreateModelDescriptionParametersTypes);

            // Assert
            parametersOfGetOrCreateModelDescription.ShouldNotBeNull();
            parametersOfGetOrCreateModelDescription.Length.ShouldBe(1);
            methodGetOrCreateModelDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var methodGetOrCreateModelDescriptionParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOrCreateModelDescription, methodGetOrCreateModelDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOrCreateModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var methodGetOrCreateModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOrCreateModelDescription, methodGetOrCreateModelDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOrCreateModelDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateModelDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOrCreateModelDescription) (Return Type : ModelDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetOrCreateModelDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOrCreateModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOrCreateModelDescription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GetMemberName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetMemberNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMemberName, methodGetMemberNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetMemberName_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var member = this.CreateType<MemberInfo>();
            var hasDataContractAttribute = this.CreateType<bool>();
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };
            object[] parametersOfGetMemberName = { member, hasDataContractAttribute };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMemberName, methodGetMemberNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_modelDescriptionGeneratorInstanceFixture, parametersOfGetMemberName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMemberName.ShouldNotBeNull();
            parametersOfGetMemberName.Length.ShouldBe(2);
            methodGetMemberNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetMemberName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var member = this.CreateType<MemberInfo>();
            var hasDataContractAttribute = this.CreateType<bool>();
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };
            object[] parametersOfGetMemberName = { member, hasDataContractAttribute };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMemberName, parametersOfGetMemberName, methodGetMemberNameParametersTypes);

            // Assert
            parametersOfGetMemberName.ShouldNotBeNull();
            parametersOfGetMemberName.Length.ShouldBe(2);
            methodGetMemberNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetMemberName_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMemberName, methodGetMemberNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMemberNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetMemberName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMemberName, methodGetMemberNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMemberNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetMemberName_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMemberName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GetMemberName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMemberName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_Internally(Type[] types)
        {
            var methodShouldDisplayMemberParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodShouldDisplayMember, methodShouldDisplayMemberParametersTypes);
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var member = this.CreateType<MemberInfo>();
            var hasDataContractAttribute = this.CreateType<bool>();
            var methodShouldDisplayMemberParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };
            object[] parametersOfShouldDisplayMember = { member, hasDataContractAttribute };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodShouldDisplayMember, methodShouldDisplayMemberParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodShouldDisplayMember, methodShouldDisplayMemberParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodShouldDisplayMember, parametersOfShouldDisplayMember, methodShouldDisplayMemberParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfShouldDisplayMember.ShouldNotBeNull();
            parametersOfShouldDisplayMember.Length.ShouldBe(2);
            methodShouldDisplayMemberParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodShouldDisplayMember, parametersOfShouldDisplayMember, methodShouldDisplayMemberParametersTypes));
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var member = this.CreateType<MemberInfo>();
            var hasDataContractAttribute = this.CreateType<bool>();
            var methodShouldDisplayMemberParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };
            object[] parametersOfShouldDisplayMember = { member, hasDataContractAttribute };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodShouldDisplayMember, methodShouldDisplayMemberParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_modelDescriptionGeneratorInstanceFixture, parametersOfShouldDisplayMember);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfShouldDisplayMember.ShouldNotBeNull();
            parametersOfShouldDisplayMember.Length.ShouldBe(2);
            methodShouldDisplayMemberParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var member = this.CreateType<MemberInfo>();
            var hasDataContractAttribute = this.CreateType<bool>();
            var methodShouldDisplayMemberParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };
            object[] parametersOfShouldDisplayMember = { member, hasDataContractAttribute };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodShouldDisplayMember, parametersOfShouldDisplayMember, methodShouldDisplayMemberParametersTypes);

            // Assert
            parametersOfShouldDisplayMember.ShouldNotBeNull();
            parametersOfShouldDisplayMember.Length.ShouldBe(2);
            methodShouldDisplayMemberParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var methodShouldDisplayMemberParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodShouldDisplayMember, methodShouldDisplayMemberParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodShouldDisplayMemberParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var methodShouldDisplayMemberParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodShouldDisplayMember, methodShouldDisplayMemberParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodShouldDisplayMemberParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var methodShouldDisplayMemberParametersTypes = new Type[] { typeof(MemberInfo), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodShouldDisplayMember, methodShouldDisplayMemberParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodShouldDisplayMemberParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var currentMethodInfo = this.GetMethodInfo(MethodShouldDisplayMember, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ShouldDisplayMember) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_ShouldDisplayMember_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodShouldDisplayMember);
            var currentMethodInfo = this.GetMethodInfo(MethodShouldDisplayMember, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateDefaultDocumentation) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_CreateDefaultDocumentation_Method_Call_Internally(Type[] types)
        {
            var methodCreateDefaultDocumentationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateDefaultDocumentation, methodCreateDefaultDocumentationParametersTypes);
        }

        #endregion

        #region Method Call : (CreateDefaultDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_CreateDefaultDocumentation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultDocumentation);
            var type = this.CreateType<Type>();
            var methodCreateDefaultDocumentationParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateDefaultDocumentation = { type };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDefaultDocumentation, methodCreateDefaultDocumentationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_modelDescriptionGeneratorInstanceFixture, parametersOfCreateDefaultDocumentation);
            var result2 = this.GetResultOfMethod<string>(MethodCreateDefaultDocumentation, parametersOfCreateDefaultDocumentation, methodCreateDefaultDocumentationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateDefaultDocumentation.ShouldNotBeNull();
            parametersOfCreateDefaultDocumentation.Length.ShouldBe(1);
            methodCreateDefaultDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateDefaultDocumentation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_CreateDefaultDocumentation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultDocumentation);
            var type = this.CreateType<Type>();
            var methodCreateDefaultDocumentationParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfCreateDefaultDocumentation = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateDefaultDocumentation, parametersOfCreateDefaultDocumentation, methodCreateDefaultDocumentationParametersTypes);

            // Assert
            parametersOfCreateDefaultDocumentation.ShouldNotBeNull();
            parametersOfCreateDefaultDocumentation.Length.ShouldBe(1);
            methodCreateDefaultDocumentationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateDefaultDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_CreateDefaultDocumentation_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultDocumentation);
            var methodCreateDefaultDocumentationParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateDefaultDocumentation, methodCreateDefaultDocumentationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateDefaultDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateDefaultDocumentation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_CreateDefaultDocumentation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultDocumentation);
            var methodCreateDefaultDocumentationParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateDefaultDocumentation, methodCreateDefaultDocumentationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateDefaultDocumentationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateDefaultDocumentation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_CreateDefaultDocumentation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDefaultDocumentation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateDefaultDocumentation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_CreateDefaultDocumentation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDefaultDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDefaultDocumentation, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateAnnotations) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GenerateAnnotations_Method_Call_Internally(Type[] types)
        {
            var methodGenerateAnnotationsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateAnnotations, methodGenerateAnnotationsParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateAnnotations) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateAnnotations_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateAnnotations);
            var property = this.CreateType<MemberInfo>();
            var propertyModel = this.CreateType<ParameterDescription>();
            var methodGenerateAnnotationsParametersTypes = new Type[] { typeof(MemberInfo), typeof(ParameterDescription) };
            object[] parametersOfGenerateAnnotations = { property, propertyModel };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateAnnotations, methodGenerateAnnotationsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_modelDescriptionGeneratorInstanceFixture, parametersOfGenerateAnnotations);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateAnnotations.ShouldNotBeNull();
            parametersOfGenerateAnnotations.Length.ShouldBe(2);
            methodGenerateAnnotationsParametersTypes.Length.ShouldBe(2);
            methodGenerateAnnotationsParametersTypes.Length.ShouldBe(parametersOfGenerateAnnotations.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateAnnotations) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateAnnotations_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateAnnotations);
            var property = this.CreateType<MemberInfo>();
            var propertyModel = this.CreateType<ParameterDescription>();
            var methodGenerateAnnotationsParametersTypes = new Type[] { typeof(MemberInfo), typeof(ParameterDescription) };
            object[] parametersOfGenerateAnnotations = { property, propertyModel };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGenerateAnnotations, parametersOfGenerateAnnotations, methodGenerateAnnotationsParametersTypes);

            // Assert
            parametersOfGenerateAnnotations.ShouldNotBeNull();
            parametersOfGenerateAnnotations.Length.ShouldBe(2);
            methodGenerateAnnotationsParametersTypes.Length.ShouldBe(2);
            methodGenerateAnnotationsParametersTypes.Length.ShouldBe(parametersOfGenerateAnnotations.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateAnnotations) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateAnnotations_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateAnnotations);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateAnnotations, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateAnnotations) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateAnnotations_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateAnnotations);
            var methodGenerateAnnotationsParametersTypes = new Type[] { typeof(MemberInfo), typeof(ParameterDescription) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateAnnotations, methodGenerateAnnotationsParametersTypes);

            // Assert
            methodGenerateAnnotationsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateAnnotations) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateAnnotations_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateAnnotations);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateAnnotations, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateCollectionModelDescription) (Return Type : CollectionModelDescription) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GenerateCollectionModelDescription_Method_Call_Internally(Type[] types)
        {
            var methodGenerateCollectionModelDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateCollectionModelDescription, methodGenerateCollectionModelDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateCollectionModelDescription) (Return Type : CollectionModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateCollectionModelDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollectionModelDescription);
            var modelType = this.CreateType<Type>();
            var elementType = this.CreateType<Type>();
            var methodGenerateCollectionModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfGenerateCollectionModelDescription = { modelType, elementType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateCollectionModelDescription, methodGenerateCollectionModelDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CollectionModelDescription>(_modelDescriptionGeneratorInstanceFixture, parametersOfGenerateCollectionModelDescription);
            var result2 = this.GetResultOfMethod<CollectionModelDescription>(MethodGenerateCollectionModelDescription, parametersOfGenerateCollectionModelDescription, methodGenerateCollectionModelDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateCollectionModelDescription.ShouldNotBeNull();
            parametersOfGenerateCollectionModelDescription.Length.ShouldBe(2);
            methodGenerateCollectionModelDescriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateCollectionModelDescription) (Return Type : CollectionModelDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateCollectionModelDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollectionModelDescription);
            var modelType = this.CreateType<Type>();
            var elementType = this.CreateType<Type>();
            var methodGenerateCollectionModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            object[] parametersOfGenerateCollectionModelDescription = { modelType, elementType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CollectionModelDescription>(MethodGenerateCollectionModelDescription, parametersOfGenerateCollectionModelDescription, methodGenerateCollectionModelDescriptionParametersTypes);

            // Assert
            parametersOfGenerateCollectionModelDescription.ShouldNotBeNull();
            parametersOfGenerateCollectionModelDescription.Length.ShouldBe(2);
            methodGenerateCollectionModelDescriptionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateCollectionModelDescription) (Return Type : CollectionModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateCollectionModelDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollectionModelDescription);
            var methodGenerateCollectionModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateCollectionModelDescription, methodGenerateCollectionModelDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateCollectionModelDescriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateCollectionModelDescription) (Return Type : CollectionModelDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateCollectionModelDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollectionModelDescription);
            var methodGenerateCollectionModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateCollectionModelDescription, methodGenerateCollectionModelDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateCollectionModelDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateCollectionModelDescription) (Return Type : CollectionModelDescription) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateCollectionModelDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollectionModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateCollectionModelDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateCollectionModelDescription) (Return Type : CollectionModelDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateCollectionModelDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollectionModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateCollectionModelDescription, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateComplexTypeModelDescription) (Return Type : ModelDescription) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GenerateComplexTypeModelDescription_Method_Call_Internally(Type[] types)
        {
            var methodGenerateComplexTypeModelDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateComplexTypeModelDescription, methodGenerateComplexTypeModelDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateComplexTypeModelDescription) (Return Type : ModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateComplexTypeModelDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexTypeModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGenerateComplexTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateComplexTypeModelDescription = { modelType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateComplexTypeModelDescription, methodGenerateComplexTypeModelDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ModelDescription>(_modelDescriptionGeneratorInstanceFixture, parametersOfGenerateComplexTypeModelDescription);
            var result2 = this.GetResultOfMethod<ModelDescription>(MethodGenerateComplexTypeModelDescription, parametersOfGenerateComplexTypeModelDescription, methodGenerateComplexTypeModelDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateComplexTypeModelDescription.ShouldNotBeNull();
            parametersOfGenerateComplexTypeModelDescription.Length.ShouldBe(1);
            methodGenerateComplexTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateComplexTypeModelDescription) (Return Type : ModelDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateComplexTypeModelDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexTypeModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGenerateComplexTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateComplexTypeModelDescription = { modelType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelDescription>(MethodGenerateComplexTypeModelDescription, parametersOfGenerateComplexTypeModelDescription, methodGenerateComplexTypeModelDescriptionParametersTypes);

            // Assert
            parametersOfGenerateComplexTypeModelDescription.ShouldNotBeNull();
            parametersOfGenerateComplexTypeModelDescription.Length.ShouldBe(1);
            methodGenerateComplexTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateComplexTypeModelDescription) (Return Type : ModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateComplexTypeModelDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexTypeModelDescription);
            var methodGenerateComplexTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateComplexTypeModelDescription, methodGenerateComplexTypeModelDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateComplexTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateComplexTypeModelDescription) (Return Type : ModelDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateComplexTypeModelDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexTypeModelDescription);
            var methodGenerateComplexTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateComplexTypeModelDescription, methodGenerateComplexTypeModelDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateComplexTypeModelDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateComplexTypeModelDescription) (Return Type : ModelDescription) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateComplexTypeModelDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexTypeModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateComplexTypeModelDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateComplexTypeModelDescription) (Return Type : ModelDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateComplexTypeModelDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexTypeModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateComplexTypeModelDescription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateDictionaryModelDescription) (Return Type : DictionaryModelDescription) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GenerateDictionaryModelDescription_Method_Call_Internally(Type[] types)
        {
            var methodGenerateDictionaryModelDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateDictionaryModelDescription, methodGenerateDictionaryModelDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateDictionaryModelDescription) (Return Type : DictionaryModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateDictionaryModelDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionaryModelDescription);
            var modelType = this.CreateType<Type>();
            var keyType = this.CreateType<Type>();
            var valueType = this.CreateType<Type>();
            var methodGenerateDictionaryModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };
            object[] parametersOfGenerateDictionaryModelDescription = { modelType, keyType, valueType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateDictionaryModelDescription, methodGenerateDictionaryModelDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DictionaryModelDescription>(_modelDescriptionGeneratorInstanceFixture, parametersOfGenerateDictionaryModelDescription);
            var result2 = this.GetResultOfMethod<DictionaryModelDescription>(MethodGenerateDictionaryModelDescription, parametersOfGenerateDictionaryModelDescription, methodGenerateDictionaryModelDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateDictionaryModelDescription.ShouldNotBeNull();
            parametersOfGenerateDictionaryModelDescription.Length.ShouldBe(3);
            methodGenerateDictionaryModelDescriptionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateDictionaryModelDescription) (Return Type : DictionaryModelDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateDictionaryModelDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionaryModelDescription);
            var modelType = this.CreateType<Type>();
            var keyType = this.CreateType<Type>();
            var valueType = this.CreateType<Type>();
            var methodGenerateDictionaryModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };
            object[] parametersOfGenerateDictionaryModelDescription = { modelType, keyType, valueType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DictionaryModelDescription>(MethodGenerateDictionaryModelDescription, parametersOfGenerateDictionaryModelDescription, methodGenerateDictionaryModelDescriptionParametersTypes);

            // Assert
            parametersOfGenerateDictionaryModelDescription.ShouldNotBeNull();
            parametersOfGenerateDictionaryModelDescription.Length.ShouldBe(3);
            methodGenerateDictionaryModelDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateDictionaryModelDescription) (Return Type : DictionaryModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateDictionaryModelDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionaryModelDescription);
            var methodGenerateDictionaryModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateDictionaryModelDescription, methodGenerateDictionaryModelDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateDictionaryModelDescriptionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateDictionaryModelDescription) (Return Type : DictionaryModelDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateDictionaryModelDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionaryModelDescription);
            var methodGenerateDictionaryModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateDictionaryModelDescription, methodGenerateDictionaryModelDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateDictionaryModelDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateDictionaryModelDescription) (Return Type : DictionaryModelDescription) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateDictionaryModelDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionaryModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateDictionaryModelDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateDictionaryModelDescription) (Return Type : DictionaryModelDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateDictionaryModelDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionaryModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateDictionaryModelDescription, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateEnumTypeModelDescription) (Return Type : EnumTypeModelDescription) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GenerateEnumTypeModelDescription_Method_Call_Internally(Type[] types)
        {
            var methodGenerateEnumTypeModelDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateEnumTypeModelDescription, methodGenerateEnumTypeModelDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateEnumTypeModelDescription) (Return Type : EnumTypeModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateEnumTypeModelDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnumTypeModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGenerateEnumTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateEnumTypeModelDescription = { modelType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateEnumTypeModelDescription, methodGenerateEnumTypeModelDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<EnumTypeModelDescription>(_modelDescriptionGeneratorInstanceFixture, parametersOfGenerateEnumTypeModelDescription);
            var result2 = this.GetResultOfMethod<EnumTypeModelDescription>(MethodGenerateEnumTypeModelDescription, parametersOfGenerateEnumTypeModelDescription, methodGenerateEnumTypeModelDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateEnumTypeModelDescription.ShouldNotBeNull();
            parametersOfGenerateEnumTypeModelDescription.Length.ShouldBe(1);
            methodGenerateEnumTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateEnumTypeModelDescription) (Return Type : EnumTypeModelDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateEnumTypeModelDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnumTypeModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGenerateEnumTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateEnumTypeModelDescription = { modelType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<EnumTypeModelDescription>(MethodGenerateEnumTypeModelDescription, parametersOfGenerateEnumTypeModelDescription, methodGenerateEnumTypeModelDescriptionParametersTypes);

            // Assert
            parametersOfGenerateEnumTypeModelDescription.ShouldNotBeNull();
            parametersOfGenerateEnumTypeModelDescription.Length.ShouldBe(1);
            methodGenerateEnumTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateEnumTypeModelDescription) (Return Type : EnumTypeModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateEnumTypeModelDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnumTypeModelDescription);
            var methodGenerateEnumTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateEnumTypeModelDescription, methodGenerateEnumTypeModelDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateEnumTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateEnumTypeModelDescription) (Return Type : EnumTypeModelDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateEnumTypeModelDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnumTypeModelDescription);
            var methodGenerateEnumTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateEnumTypeModelDescription, methodGenerateEnumTypeModelDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateEnumTypeModelDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateEnumTypeModelDescription) (Return Type : EnumTypeModelDescription) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateEnumTypeModelDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnumTypeModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateEnumTypeModelDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateEnumTypeModelDescription) (Return Type : EnumTypeModelDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateEnumTypeModelDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnumTypeModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateEnumTypeModelDescription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePairModelDescription) (Return Type : KeyValuePairModelDescription) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GenerateKeyValuePairModelDescription_Method_Call_Internally(Type[] types)
        {
            var methodGenerateKeyValuePairModelDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateKeyValuePairModelDescription, methodGenerateKeyValuePairModelDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePairModelDescription) (Return Type : KeyValuePairModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateKeyValuePairModelDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePairModelDescription);
            var modelType = this.CreateType<Type>();
            var keyType = this.CreateType<Type>();
            var valueType = this.CreateType<Type>();
            var methodGenerateKeyValuePairModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };
            object[] parametersOfGenerateKeyValuePairModelDescription = { modelType, keyType, valueType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateKeyValuePairModelDescription, methodGenerateKeyValuePairModelDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<KeyValuePairModelDescription>(_modelDescriptionGeneratorInstanceFixture, parametersOfGenerateKeyValuePairModelDescription);
            var result2 = this.GetResultOfMethod<KeyValuePairModelDescription>(MethodGenerateKeyValuePairModelDescription, parametersOfGenerateKeyValuePairModelDescription, methodGenerateKeyValuePairModelDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateKeyValuePairModelDescription.ShouldNotBeNull();
            parametersOfGenerateKeyValuePairModelDescription.Length.ShouldBe(3);
            methodGenerateKeyValuePairModelDescriptionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePairModelDescription) (Return Type : KeyValuePairModelDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateKeyValuePairModelDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePairModelDescription);
            var modelType = this.CreateType<Type>();
            var keyType = this.CreateType<Type>();
            var valueType = this.CreateType<Type>();
            var methodGenerateKeyValuePairModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };
            object[] parametersOfGenerateKeyValuePairModelDescription = { modelType, keyType, valueType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<KeyValuePairModelDescription>(MethodGenerateKeyValuePairModelDescription, parametersOfGenerateKeyValuePairModelDescription, methodGenerateKeyValuePairModelDescriptionParametersTypes);

            // Assert
            parametersOfGenerateKeyValuePairModelDescription.ShouldNotBeNull();
            parametersOfGenerateKeyValuePairModelDescription.Length.ShouldBe(3);
            methodGenerateKeyValuePairModelDescriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePairModelDescription) (Return Type : KeyValuePairModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateKeyValuePairModelDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePairModelDescription);
            var methodGenerateKeyValuePairModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateKeyValuePairModelDescription, methodGenerateKeyValuePairModelDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateKeyValuePairModelDescriptionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePairModelDescription) (Return Type : KeyValuePairModelDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateKeyValuePairModelDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePairModelDescription);
            var methodGenerateKeyValuePairModelDescriptionParametersTypes = new Type[] { typeof(Type), typeof(Type), typeof(Type) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateKeyValuePairModelDescription, methodGenerateKeyValuePairModelDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateKeyValuePairModelDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePairModelDescription) (Return Type : KeyValuePairModelDescription) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateKeyValuePairModelDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePairModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateKeyValuePairModelDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateKeyValuePairModelDescription) (Return Type : KeyValuePairModelDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateKeyValuePairModelDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePairModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateKeyValuePairModelDescription, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateSimpleTypeModelDescription) (Return Type : ModelDescription) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ModelDescriptionGenerator_GenerateSimpleTypeModelDescription_Method_Call_Internally(Type[] types)
        {
            var methodGenerateSimpleTypeModelDescriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateSimpleTypeModelDescription, methodGenerateSimpleTypeModelDescriptionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateSimpleTypeModelDescription) (Return Type : ModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateSimpleTypeModelDescription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSimpleTypeModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGenerateSimpleTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateSimpleTypeModelDescription = { modelType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateSimpleTypeModelDescription, methodGenerateSimpleTypeModelDescriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ModelDescription>(_modelDescriptionGeneratorInstanceFixture, parametersOfGenerateSimpleTypeModelDescription);
            var result2 = this.GetResultOfMethod<ModelDescription>(MethodGenerateSimpleTypeModelDescription, parametersOfGenerateSimpleTypeModelDescription, methodGenerateSimpleTypeModelDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateSimpleTypeModelDescription.ShouldNotBeNull();
            parametersOfGenerateSimpleTypeModelDescription.Length.ShouldBe(1);
            methodGenerateSimpleTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateSimpleTypeModelDescription) (Return Type : ModelDescription) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateSimpleTypeModelDescription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSimpleTypeModelDescription);
            var modelType = this.CreateType<Type>();
            var methodGenerateSimpleTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateSimpleTypeModelDescription = { modelType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ModelDescription>(MethodGenerateSimpleTypeModelDescription, parametersOfGenerateSimpleTypeModelDescription, methodGenerateSimpleTypeModelDescriptionParametersTypes);

            // Assert
            parametersOfGenerateSimpleTypeModelDescription.ShouldNotBeNull();
            parametersOfGenerateSimpleTypeModelDescription.Length.ShouldBe(1);
            methodGenerateSimpleTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateSimpleTypeModelDescription) (Return Type : ModelDescription) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateSimpleTypeModelDescription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSimpleTypeModelDescription);
            var methodGenerateSimpleTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateSimpleTypeModelDescription, methodGenerateSimpleTypeModelDescriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateSimpleTypeModelDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateSimpleTypeModelDescription) (Return Type : ModelDescription) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateSimpleTypeModelDescription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSimpleTypeModelDescription);
            var methodGenerateSimpleTypeModelDescriptionParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateSimpleTypeModelDescription, methodGenerateSimpleTypeModelDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateSimpleTypeModelDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateSimpleTypeModelDescription) (Return Type : ModelDescription) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateSimpleTypeModelDescription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSimpleTypeModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateSimpleTypeModelDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateSimpleTypeModelDescription) (Return Type : ModelDescription) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ModelDescriptionGenerator_GenerateSimpleTypeModelDescription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateSimpleTypeModelDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateSimpleTypeModelDescription, 0);
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