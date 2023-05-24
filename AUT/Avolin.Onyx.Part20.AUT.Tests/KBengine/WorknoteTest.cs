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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.Worknote" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class WorknoteTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="WorknoteNonPublicTypeName" />) using
        ///     Using a public type <see cref="AppLogEvent" /> to
        ///     create a non-public type.
        /// </summary>
        public WorknoteTest() : base(publicType: typeof(AppLogEvent), classNameWithNamespace: WorknoteNonPublicTypeName)
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

        private Type _worknoteInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string WorknoteNonPublicTypeName = "KBengine.Worknote";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _worknoteInstance;
        private object _worknoteInstanceFixture;

        #region General Initializer : Class (Worknote) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Worknote" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _worknoteInstanceFixture = this.CreateNonPublicType(WorknoteNonPublicTypeName);
            _worknoteInstance = _worknoteInstanceFixture;
            CurrentInstance = _worknoteInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Worknote) Initializer

        #region Properties

        private const string PropertyHTMLWorknotes = "HTMLWorknotes";
        private const string PropertyOnyxDBVersion = "OnyxDBVersion";
        private const string PropertyPublishLevel = "PublishLevel";
        private const string PropertyEnteredBy = "EnteredBy";

        #endregion

        #region Methods

        private const string MethodRead = "Read";
        private const string MethodReadWorkNotes = "ReadWorkNotes";
        private const string MethodReadLogmarkWT = "ReadLogmarkWT";
        private const string MethodLogmark = "Logmark";
        private const string MethodsProcessArgString = "sProcessArgString";
        private const string MethodReadSQLText60 = "ReadSQLText60";
        private const string MethodReadRow = "ReadRow";
        private const string MethodProcessBlock = "ProcessBlock";
        private const string MethodClear = "Clear";

        #endregion

        #region Fields

        private const string FieldLOGMARK_PREFIX = "LOGMARK_PREFIX";
        private const string FieldLOGMARK_SUFFIX = "LOGMARK_SUFFIX";
        private const string FieldWEB_PREFIX = "WEB_PREFIX";
        private const string FieldWEB_SUFFIX = "WEB_SUFFIX";
        private const string FieldPUBLISH_PREFIX = "PUBLISH_PREFIX";
        private const string FieldPUBLISH_SUFFIX = "PUBLISH_SUFFIX";
        private const string FieldPUBLISHRESET_PREFIX = "PUBLISHRESET_PREFIX";
        private const string FieldPUBLISHRESET_SUFFIX = "PUBLISHRESET_SUFFIX";
        private const string FieldRESET_PREFIX = "RESET_PREFIX";
        private const string FieldRESET_SUFFIX = "RESET_SUFFIX";
        private const string FieldDONTPUBLISH_PREFIX = "DONTPUBLISH_PREFIX";
        private const string FieldDONTPUBLISH_SUFFIX = "DONTPUBLISH_SUFFIX";
        private const string FieldPUBLISH = "PUBLISH";
        private const string FieldENDPUBLISH = "ENDPUBLISH";
        private const string FieldRESET = "RESET";
        private const string FieldWEB = "WEB";
        private const string FieldmsEnteredBy = "msEnteredBy";
        private const string FieldmsFirstLogStart = "msFirstLogStart";
        private const string FieldmsOtherLogStart = "msOtherLogStart";
        private const string FieldmsEndLog = "msEndLog";
        private const string FieldmsFirstLogStartOld = "msFirstLogStartOld";
        private const string FieldmsOtherLogStartOld = "msOtherLogStartOld";
        private const string FieldmsHTMLWorknotes = "msHTMLWorknotes";
        private const string FieldmiOnyxDBVersion = "miOnyxDBVersion";
        private const string FieldmiPublishLevel = "miPublishLevel";
        private const string FieldmiLatestPublish = "miLatestPublish";
        private const string FieldmsLatestBlock = "msLatestBlock";
        private const string FieldmsLatestLogmark = "msLatestLogmark";
        private const string Field_OnyxDBVersion = "_OnyxDBVersion";
        private const string FieldWORKNOTE_PUBLISH = "WORKNOTE_PUBLISH";
        private const string FieldWORKNOTE_WEB = "WORKNOTE_WEB";
        private const string FieldWORKNOTE_PUBLISHRESET = "WORKNOTE_PUBLISHRESET";
        private const string FieldWORKNOTE_RESET = "WORKNOTE_RESET";
        private const string FieldmsText = "msText";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Worknote)

        #region General Initializer : Class (Worknote) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Worknote" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRead, 0)]
        [TestCase(MethodReadWorkNotes, 0)]
        [TestCase(MethodReadLogmarkWT, 0)]
        [TestCase(MethodLogmark, 0)]
        [TestCase(MethodsProcessArgString, 0)]
        [TestCase(MethodReadSQLText60, 0)]
        [TestCase(MethodReadRow, 0)]
        [TestCase(MethodProcessBlock, 0)]
        [TestCase(MethodClear, 0)]
        [Category("AUT Explore")]
        public void AUT_Worknote_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Worknote) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Worknote" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Worknote_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Worknote) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Worknote" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyHTMLWorknotes)]
        [TestCase(PropertyOnyxDBVersion)]
        [TestCase(PropertyPublishLevel)]
        [TestCase(PropertyEnteredBy)]
        [Category("AUT Property")]
        public void AUT_Worknote_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Worknote) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Worknote" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Worknote_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Worknote) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Worknote" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldLOGMARK_PREFIX)]
        [TestCase(FieldLOGMARK_SUFFIX)]
        [TestCase(FieldWEB_PREFIX)]
        [TestCase(FieldWEB_SUFFIX)]
        [TestCase(FieldPUBLISH_PREFIX)]
        [TestCase(FieldPUBLISH_SUFFIX)]
        [TestCase(FieldPUBLISHRESET_PREFIX)]
        [TestCase(FieldPUBLISHRESET_SUFFIX)]
        [TestCase(FieldRESET_PREFIX)]
        [TestCase(FieldRESET_SUFFIX)]
        [TestCase(FieldDONTPUBLISH_PREFIX)]
        [TestCase(FieldDONTPUBLISH_SUFFIX)]
        [TestCase(FieldPUBLISH)]
        [TestCase(FieldENDPUBLISH)]
        [TestCase(FieldRESET)]
        [TestCase(FieldWEB)]
        [TestCase(FieldmsEnteredBy)]
        [TestCase(FieldmsFirstLogStart)]
        [TestCase(FieldmsOtherLogStart)]
        [TestCase(FieldmsEndLog)]
        [TestCase(FieldmsFirstLogStartOld)]
        [TestCase(FieldmsOtherLogStartOld)]
        [TestCase(FieldmsHTMLWorknotes)]
        [TestCase(FieldmiOnyxDBVersion)]
        [TestCase(FieldmiPublishLevel)]
        [TestCase(FieldmiLatestPublish)]
        [TestCase(FieldmsLatestBlock)]
        [TestCase(FieldmsLatestLogmark)]
        [TestCase(Field_OnyxDBVersion)]
        [TestCase(FieldWORKNOTE_PUBLISH)]
        [TestCase(FieldWORKNOTE_WEB)]
        [TestCase(FieldWORKNOTE_PUBLISHRESET)]
        [TestCase(FieldWORKNOTE_RESET)]
        [TestCase(FieldmsText)]
        [Category("AUT Fields")]
        public void AUT_Worknote_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Worknote) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Worknote" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Worknote_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Worknote) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyHTMLWorknotes)]
        [TestCase(PropertyOnyxDBVersion)]
        [TestCase(PropertyPublishLevel)]
        [TestCase(PropertyEnteredBy)]
        public void AUT_Worknote_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Worknote) => Property (EnteredBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknote_Public_Class_EnteredBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnteredBy);
            var propertyInfo = this.GetPropertyInfo(PropertyEnteredBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Worknote) => Property (HTMLWorknotes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknote_Public_Class_HTMLWorknotes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHTMLWorknotes);
            var propertyInfo = this.GetPropertyInfo(PropertyHTMLWorknotes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Worknote) => Property (OnyxDBVersion) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknote_Public_Class_OnyxDBVersion_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxDBVersion);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxDBVersion);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Worknote) => Property (PublishLevel) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Worknote_Public_Class_PublishLevel_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPublishLevel);
            var propertyInfo = this.GetPropertyInfo(PropertyPublishLevel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}