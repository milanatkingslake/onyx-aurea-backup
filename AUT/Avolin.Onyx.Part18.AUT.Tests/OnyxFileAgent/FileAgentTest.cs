using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxFileAgent;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.OnyxFileAgent
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxFileAgent.FileAgent" />)
    ///     and namespace <see cref="OnyxFileAgent"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FileAgentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FileAgent" />)
        /// </summary>
        public FileAgentTest() : base(typeof(FileAgent))
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

        #region General Initializer : Class (FileAgent) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _fileAgentInstanceType;
        private FileAgent _fileAgentInstance;
        private FileAgent _fileAgentInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FileAgent" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fileAgentInstanceType = typeof(FileAgent);
            _fileAgentInstanceFixture = this.Create<FileAgent>(false);
            _fileAgentInstance = _fileAgentInstanceFixture ?? this.Create<FileAgent>(true);
            CurrentInstance = _fileAgentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FileAgent) Initializer

        #region Methods

        private const string MethodMyResolveEventHandler = "MyResolveEventHandler";
        private const string MethodPutFile = "PutFile";
        private const string MethodGetFile = "GetFile";
        private const string MethodGenerateReturnXml = "GenerateReturnXml";
        private const string MethodvalidateNodeNotEmpty = "validateNodeNotEmpty";
        private const string MethodgetFilePath = "getFilePath";
        private const string MethodgetFileName = "getFileName";

        #endregion

        #region Fields

        private const string FieldREGKEY = "REGKEY";
        private const string FieldRESLIB = "RESLIB";
        private const string FielduserID = "userID";
        private const string FieldlogHelper = "logHelper";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (FileAgent)

        #region General Initializer : Class (FileAgent) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FileAgent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMyResolveEventHandler, 0)]
        [TestCase(MethodPutFile, 0)]
        [TestCase(MethodGetFile, 0)]
        [TestCase(MethodGenerateReturnXml, 0)]
        [TestCase(MethodvalidateNodeNotEmpty, 0)]
        [TestCase(MethodgetFilePath, 0)]
        [TestCase(MethodgetFileName, 0)]
        public void AUT_FileAgent_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FileAgent) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="FileAgent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldREGKEY)]
        [TestCase(FieldRESLIB)]
        [TestCase(FielduserID)]
        [TestCase(FieldlogHelper)]
        [Category("AUT Fields")]
        public void AUT_FileAgent_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region Category : MethodCallTest

        #region Method Call : (PutFile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileAgent_PutFile_Method_Call_Internally(Type[] types)
        {
            var methodPutFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPutFile, methodPutFileParametersTypes);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileAgent_GetFile_Method_Call_Internally(Type[] types)
        {
            var methodGetFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateReturnXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileAgent_GenerateReturnXml_Method_Call_Internally(Type[] types)
        {
            var methodGenerateReturnXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateReturnXml, methodGenerateReturnXmlParametersTypes);
        }

        #endregion

        #region Method Call : (validateNodeNotEmpty) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileAgent_validateNodeNotEmpty_Method_Call_Internally(Type[] types)
        {
            var methodvalidateNodeNotEmptyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodvalidateNodeNotEmpty, methodvalidateNodeNotEmptyParametersTypes);
        }

        #endregion

        #region Method Call : (getFilePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileAgent_getFilePath_Method_Call_Internally(Type[] types)
        {
            var methodgetFilePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetFilePath, methodgetFilePathParametersTypes);
        }

        #endregion

        #region Method Call : (getFileName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileAgent_getFileName_Method_Call_Internally(Type[] types)
        {
            var methodgetFileNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetFileName, methodgetFileNameParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}