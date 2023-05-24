using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using KBengine;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.KBengine
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.Program" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ProgramTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ProgramNonPublicTypeName" />) using
        ///     Using a public type <see cref="AppLogEvent" /> to
        ///     create a non-public type.
        /// </summary>
        public ProgramTest() : base(publicType: typeof(AppLogEvent), classNameWithNamespace: ProgramNonPublicTypeName)
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

        private Type _programInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ProgramNonPublicTypeName = "KBengine.Program";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _programInstance;
        private object _programInstanceFixture;

        #region General Initializer : Class (Program) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Program" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _programInstanceFixture = this.CreateNonPublicType(ProgramNonPublicTypeName);
            _programInstance = _programInstanceFixture;
            CurrentInstance = _programInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Program) Initializer

        #region Methods

        private const string MethodMain = "Main";
        
        private const string MethodbGetExtractionProfile = "bGetExtractionProfile";
        private const string MethodbValidateDestDir = "bValidateDestDir";
        private const string MethodbProcessExtractionList = "bProcessExtractionList";
        private const string MethodsFileContents = "sFileContents";
        private const string MethodsGetResourceStrings = "sGetResourceStrings";
        private const string MethodsGetResourceString = "sGetResourceString";
        private const string MethodsFormatPlaceholder = "sFormatPlaceholder";
        private const string MethodbProcessDeletionList = "bProcessDeletionList";
        private const string MethodbUpdateExtractionProfile = "bUpdateExtractionProfile";
        private const string MethodsCreateVersionString = "sCreateVersionString";
        private const string MethodDecryptConnectionString = "DecryptConnectionString";
        private const string MethodaddConnectionTimeOut = "addConnectionTimeOut";
        private const string MethodDecryptText = "DecryptText";
        private const string MethodGetRelativePath = "GetRelativePath";

        #endregion

        #region Fields

        private const string FieldDEFAULT_SOURCE_CODEPAGE = "DEFAULT_SOURCE_CODEPAGE";
        private const string FieldDEFAULT_TARGET_CODEPAGE = "DEFAULT_TARGET_CODEPAGE";
        private const string FieldgsVersion = "gsVersion";
        private const string FieldlSourceCP = "lSourceCP";
        private const string FieldlTargetCP = "lTargetCP";
        private const string FieldgsResourceStrings = "gsResourceStrings";
        private const string FieldgExtractionProfile = "gExtractionProfile";
        private const string FieldgUser = "gUser";
        private const string FieldmbEnableWorkTickets = "mbEnableWorkTickets";
        private const string FieldmlExtractionCount = "mlExtractionCount";
        private const string FieldmlDeletionCount = "mlDeletionCount";
        private const string FieldmdStartTime = "mdStartTime";
        private const string FieldmbProcessComplete = "mbProcessComplete";
        private const string FieldmsLogFilePath = "msLogFilePath";
        private const string FieldApp = "App";
        private const string Fieldmd = "md";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Program)

        #region General Initializer : Class (Program) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMain, 0)]
        [TestCase(MethodbGetExtractionProfile, 0)]
        [TestCase(MethodbValidateDestDir, 0)]
        [TestCase(MethodbProcessExtractionList, 0)]
        [TestCase(MethodsFileContents, 0)]
        [TestCase(MethodsGetResourceStrings, 0)]
        [TestCase(MethodsGetResourceString, 0)]
        [TestCase(MethodsFormatPlaceholder, 0)]
        [TestCase(MethodbProcessDeletionList, 0)]
        [TestCase(MethodbUpdateExtractionProfile, 0)]
        [TestCase(MethodsCreateVersionString, 0)]
        [TestCase(MethodDecryptConnectionString, 0)]
        [TestCase(MethodaddConnectionTimeOut, 0)]
        [TestCase(MethodDecryptText, 0)]
        [TestCase(MethodGetRelativePath, 0)]
        [Category("AUT Explore")]
        public void AUT_Program_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Program) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Program_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Program) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Program" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldDEFAULT_SOURCE_CODEPAGE)]
        [TestCase(FieldDEFAULT_TARGET_CODEPAGE)]
        [TestCase(FieldgsVersion)]
        [TestCase(FieldlSourceCP)]
        [TestCase(FieldlTargetCP)]
        [TestCase(FieldgsResourceStrings)]
        [TestCase(FieldgExtractionProfile)]
        [TestCase(FieldgUser)]
        [TestCase(FieldmbEnableWorkTickets)]
        [TestCase(FieldmlExtractionCount)]
        [TestCase(FieldmlDeletionCount)]
        [TestCase(FieldmdStartTime)]
        [TestCase(FieldmbProcessComplete)]
        [TestCase(FieldmsLogFilePath)]
        [TestCase(FieldApp)]
        [TestCase(Fieldmd)]
        [Category("AUT Fields")]
        public void AUT_Program_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion
    }
}