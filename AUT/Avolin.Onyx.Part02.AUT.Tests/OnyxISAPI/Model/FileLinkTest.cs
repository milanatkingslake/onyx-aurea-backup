using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.FileLink" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FileLinkTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FileLink" />)
        /// </summary>
        public FileLinkTest() : base(typeof(FileLink))
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

        #region General Initializer : Class (FileLink) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _fileLinkInstanceType;
        private FileLink _fileLinkInstance;
        private FileLink _fileLinkInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FileLink" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fileLinkInstanceType = typeof(FileLink);
            _fileLinkInstanceFixture = this.Create<FileLink>(false);
            _fileLinkInstance = _fileLinkInstanceFixture ?? this.Create<FileLink>(true);
            CurrentInstance = _fileLinkInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FileLink) Initializer

        #region Methods

        private const string MethodFileUpload = "FileUpload";
        private const string MethodconverterDemo = "converterDemo";
        private const string MethodFileDownload = "FileDownload";
        private const string MethodSave = "Save";
        private const string MethodgetFileLocationXml = "getFileLocationXml";
        private const string MethodcreateOFAXml = "createOFAXml";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (FileLink) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FileLink" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FileLink_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (FileLink) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FileLink" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FileLink_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FileLink)

        #region General Initializer : Class (FileLink) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FileLink" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodFileUpload, 0)]
        [TestCase(MethodconverterDemo, 0)]
        [TestCase(MethodFileDownload, 0)]
        [TestCase(MethodSave, 0)]
        [TestCase(MethodgetFileLocationXml, 0)]
        [TestCase(MethodcreateOFAXml, 0)]
        public void AUT_FileLink_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FileLink) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="FileLink" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_FileLink_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (FileLink) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FileLink" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FileLink_Is_Instance_Present_Test()
        {
            // Assert
            _fileLinkInstanceType.ShouldNotBeNull();
            _fileLinkInstance.ShouldNotBeNull();
            _fileLinkInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FileLink) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FileLink" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FileLink_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _fileLinkInstance.ShouldBeAssignableTo<FileLink>();
            _fileLinkInstanceFixture.ShouldBeAssignableTo<FileLink>();
            CurrentInstance.ShouldBeAssignableTo<FileLink>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FileLink) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FileLink_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            FileLink instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FileLink(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _fileLinkInstance.ShouldNotBeNull();
            _fileLinkInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<FileLink>();
        }

        #endregion

        #region General Constructor : Class (FileLink) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FileLink_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            FileLink instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FileLink(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _fileLinkInstance.ShouldNotBeNull();
            _fileLinkInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (FileUpload) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileUpload_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileUpload);

            // Act
            Action executeAction = () => _fileLinkInstance.FileUpload();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FileUpload) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileUpload_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileUpload);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _fileLinkInstance.FileUpload();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileUpload) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileUpload_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileUpload);
            Type [] methodFileUploadParametersTypes = null;
            object[] parametersOfFileUpload = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFileUpload, methodFileUploadParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_fileLinkInstanceFixture, parametersOfFileUpload);
            var result2 = this.GetResultOfMethod<string>(MethodFileUpload, parametersOfFileUpload, methodFileUploadParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFileUpload.ShouldBeNull();
            methodFileUploadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileUpload) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileUpload_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileUpload);
            Type [] methodFileUploadParametersTypes = null;
            object[] parametersOfFileUpload = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodFileUpload, parametersOfFileUpload, methodFileUploadParametersTypes);

            // Assert
            parametersOfFileUpload.ShouldBeNull();
            methodFileUploadParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FileUpload) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileUpload_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileUpload);
            Type [] methodFileUploadParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFileUpload, methodFileUploadParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFileUploadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileUpload) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileUpload_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileUpload);
            Type [] methodFileUploadParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFileUpload, methodFileUploadParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFileUploadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileUpload) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileUpload_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileUpload);
            var currentMethodInfo = this.GetMethodInfo(MethodFileUpload, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileLink_converterDemo_Static_Method_Call_Internally(Type[] types)
        {
            var methodconverterDemoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconverterDemo, methodconverterDemoParametersTypes);
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var x = this.CreateType<Image>();

            // Act
            Action executeAction = () => FileLink.converterDemo(x);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var x = this.CreateType<Image>();
            var returnedValue = default(byte[]);

            // Act
            Action executeAction = () => returnedValue = FileLink.converterDemo(x);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[])  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var x = this.CreateType<Image>();
            var methodconverterDemoParametersTypes = new Type[] { typeof(Image) };
            object[] parametersOfconverterDemo = { x };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconverterDemo, methodconverterDemoParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodconverterDemo, methodconverterDemoParametersTypes);
            var result2 = this.GetResultOfMethod<byte[]>(MethodconverterDemo, parametersOfconverterDemo, methodconverterDemoParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfconverterDemo.ShouldNotBeNull();
            parametersOfconverterDemo.Length.ShouldBe(1);
            methodconverterDemoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<byte[]>(MethodconverterDemo, parametersOfconverterDemo, methodconverterDemoParametersTypes));
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var x = this.CreateType<Image>();
            var methodconverterDemoParametersTypes = new Type[] { typeof(Image) };
            object[] parametersOfconverterDemo = { x };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodconverterDemo, methodconverterDemoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_fileLinkInstanceFixture, parametersOfconverterDemo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfconverterDemo.ShouldNotBeNull();
            parametersOfconverterDemo.Length.ShouldBe(1);
            methodconverterDemoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var x = this.CreateType<Image>();
            var methodconverterDemoParametersTypes = new Type[] { typeof(Image) };
            object[] parametersOfconverterDemo = { x };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodconverterDemo, parametersOfconverterDemo, methodconverterDemoParametersTypes);

            // Assert
            parametersOfconverterDemo.ShouldNotBeNull();
            parametersOfconverterDemo.Length.ShouldBe(1);
            methodconverterDemoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var methodconverterDemoParametersTypes = new Type[] { typeof(Image) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconverterDemo, methodconverterDemoParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodconverterDemoParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var methodconverterDemoParametersTypes = new Type[] { typeof(Image) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconverterDemo, methodconverterDemoParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconverterDemoParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var currentMethodInfo = this.GetMethodInfo(MethodconverterDemo, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (converterDemo) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_converterDemo_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconverterDemo);
            var currentMethodInfo = this.GetMethodInfo(MethodconverterDemo, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FileDownload) (Return Type : Object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileLink_FileDownload_Method_Call_Internally(Type[] types)
        {
            var methodFileDownloadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFileDownload, methodFileDownloadParametersTypes);
        }

        #endregion

        #region Method Call : (FileDownload) (Return Type : Object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileDownload_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileDownload);
            var returnedValue = default(Object);

            // Act
            Action executeAction = () => returnedValue = _fileLinkInstance.FileDownload();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileDownload) (Return Type : Object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileDownload_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileDownload);
            Type [] methodFileDownloadParametersTypes = null;
            object[] parametersOfFileDownload = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFileDownload, methodFileDownloadParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Object>(_fileLinkInstanceFixture, parametersOfFileDownload);
            var result2 = this.GetResultOfMethod<Object>(MethodFileDownload, parametersOfFileDownload, methodFileDownloadParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFileDownload.ShouldBeNull();
            methodFileDownloadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileDownload) (Return Type : Object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileDownload_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileDownload);
            Type [] methodFileDownloadParametersTypes = null;
            object[] parametersOfFileDownload = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Object>(MethodFileDownload, parametersOfFileDownload, methodFileDownloadParametersTypes);

            // Assert
            parametersOfFileDownload.ShouldBeNull();
            methodFileDownloadParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FileDownload) (Return Type : Object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileDownload_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileDownload);
            Type [] methodFileDownloadParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFileDownload, methodFileDownloadParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFileDownloadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileDownload) (Return Type : Object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileDownload_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileDownload);
            Type [] methodFileDownloadParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFileDownload, methodFileDownloadParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFileDownloadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FileDownload) (Return Type : Object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_FileDownload_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFileDownload);
            var currentMethodInfo = this.GetMethodInfo(MethodFileDownload, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileLink_Save_Method_Call_Internally(Type[] types)
        {
            var methodSaveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_Save_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);

            // Act
            Action executeAction = () => _fileLinkInstance.Save();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_Save_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _fileLinkInstance.Save();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_Save_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;
            object[] parametersOfSave = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSave, methodSaveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_fileLinkInstanceFixture, parametersOfSave);
            var result2 = this.GetResultOfMethod<string>(MethodSave, parametersOfSave, methodSaveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSave.ShouldBeNull();
            methodSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_Save_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;
            object[] parametersOfSave = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSave, parametersOfSave, methodSaveParametersTypes);

            // Assert
            parametersOfSave.ShouldBeNull();
            methodSaveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_Save_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_Save_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            Type [] methodSaveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSave, methodSaveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Save) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_Save_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSave);
            var currentMethodInfo = this.GetMethodInfo(MethodSave, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileLink_getFileLocationXml_Method_Call_Internally(Type[] types)
        {
            var methodgetFileLocationXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetFileLocationXml, methodgetFileLocationXmlParametersTypes);
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_getFileLocationXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetFileLocationXml);

            // Act
            Action executeAction = () => _fileLinkInstance.getFileLocationXml();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_getFileLocationXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetFileLocationXml);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _fileLinkInstance.getFileLocationXml();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_getFileLocationXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetFileLocationXml);
            Type [] methodgetFileLocationXmlParametersTypes = null;
            object[] parametersOfgetFileLocationXml = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetFileLocationXml, methodgetFileLocationXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_fileLinkInstanceFixture, parametersOfgetFileLocationXml);
            var result2 = this.GetResultOfMethod<string>(MethodgetFileLocationXml, parametersOfgetFileLocationXml, methodgetFileLocationXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetFileLocationXml.ShouldBeNull();
            methodgetFileLocationXmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_getFileLocationXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetFileLocationXml);
            Type [] methodgetFileLocationXmlParametersTypes = null;
            object[] parametersOfgetFileLocationXml = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodgetFileLocationXml, parametersOfgetFileLocationXml, methodgetFileLocationXmlParametersTypes);

            // Assert
            parametersOfgetFileLocationXml.ShouldBeNull();
            methodgetFileLocationXmlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_getFileLocationXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetFileLocationXml);
            Type [] methodgetFileLocationXmlParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetFileLocationXml, methodgetFileLocationXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetFileLocationXmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_getFileLocationXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetFileLocationXml);
            Type [] methodgetFileLocationXmlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetFileLocationXml, methodgetFileLocationXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetFileLocationXmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getFileLocationXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_getFileLocationXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetFileLocationXml);
            var currentMethodInfo = this.GetMethodInfo(MethodgetFileLocationXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileLink_createOFAXml_Method_Call_Internally(Type[] types)
        {
            var methodcreateOFAXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodcreateOFAXml, methodcreateOFAXmlParametersTypes);
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var PhysicalName = this.CreateType<Guid>();
            var OriginalName = this.CreateType<string>();
            var OEPFileLocationPath = this.CreateType<string>();
            var Extention = this.CreateType<string>();

            // Act
            Action executeAction = () => _fileLinkInstance.createOFAXml(PhysicalName, OriginalName, OEPFileLocationPath, Extention);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var PhysicalName = this.CreateType<Guid>();
            var OriginalName = this.CreateType<string>();
            var OEPFileLocationPath = this.CreateType<string>();
            var Extention = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _fileLinkInstance.createOFAXml(PhysicalName, OriginalName, OEPFileLocationPath, Extention);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var PhysicalName = this.CreateType<Guid>();
            var OriginalName = this.CreateType<string>();
            var OEPFileLocationPath = this.CreateType<string>();
            var Extention = this.CreateType<string>();
            var methodcreateOFAXmlParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfcreateOFAXml = { PhysicalName, OriginalName, OEPFileLocationPath, Extention };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateOFAXml, methodcreateOFAXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_fileLinkInstanceFixture, out exception1, parametersOfcreateOFAXml);
            var result2 = this.GetResultOfMethod<string>(MethodcreateOFAXml, parametersOfcreateOFAXml, methodcreateOFAXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfcreateOFAXml.ShouldNotBeNull();
            parametersOfcreateOFAXml.Length.ShouldBe(4);
            methodcreateOFAXmlParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var PhysicalName = this.CreateType<Guid>();
            var OriginalName = this.CreateType<string>();
            var OEPFileLocationPath = this.CreateType<string>();
            var Extention = this.CreateType<string>();
            var methodcreateOFAXmlParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfcreateOFAXml = { PhysicalName, OriginalName, OEPFileLocationPath, Extention };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodcreateOFAXml, methodcreateOFAXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_fileLinkInstanceFixture, parametersOfcreateOFAXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfcreateOFAXml.ShouldNotBeNull();
            parametersOfcreateOFAXml.Length.ShouldBe(4);
            methodcreateOFAXmlParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var PhysicalName = this.CreateType<Guid>();
            var OriginalName = this.CreateType<string>();
            var OEPFileLocationPath = this.CreateType<string>();
            var Extention = this.CreateType<string>();
            var methodcreateOFAXmlParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfcreateOFAXml = { PhysicalName, OriginalName, OEPFileLocationPath, Extention };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodcreateOFAXml, parametersOfcreateOFAXml, methodcreateOFAXmlParametersTypes);

            // Assert
            parametersOfcreateOFAXml.ShouldNotBeNull();
            parametersOfcreateOFAXml.Length.ShouldBe(4);
            methodcreateOFAXmlParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var methodcreateOFAXmlParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodcreateOFAXml, methodcreateOFAXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodcreateOFAXmlParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var methodcreateOFAXmlParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodcreateOFAXml, methodcreateOFAXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodcreateOFAXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateOFAXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (createOFAXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileLink_createOFAXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodcreateOFAXml);
            var currentMethodInfo = this.GetMethodInfo(MethodcreateOFAXml, 0);
            const int parametersCount = 4;

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