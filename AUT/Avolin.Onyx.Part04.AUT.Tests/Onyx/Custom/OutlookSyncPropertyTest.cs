using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.OutlookSyncProperty" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OutlookSyncPropertyTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OutlookSyncPropertyNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public OutlookSyncPropertyTest() : base(publicType: typeof(Common), classNameWithNamespace: OutlookSyncPropertyNonPublicTypeName)
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

        private Type _outlookSyncPropertyInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OutlookSyncPropertyNonPublicTypeName = "Onyx.Custom.OutlookSyncProperty";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _outlookSyncPropertyInstance;
        private object _outlookSyncPropertyInstanceFixture;

        #region General Initializer : Class (OutlookSyncProperty) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OutlookSyncProperty" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookSyncPropertyInstanceFixture = this.CreateNonPublicType(OutlookSyncPropertyNonPublicTypeName);
            _outlookSyncPropertyInstance = _outlookSyncPropertyInstanceFixture;
            CurrentInstance = _outlookSyncPropertyInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookSyncProperty) Initializer

        #region Methods

        private const string MethodgetOutlookPropertyCollection = "getOutlookPropertyCollection";

        #endregion

        #region Fields

        private const string FieldmsOutlookPropertyNameXslFullFileName = "msOutlookPropertyNameXslFullFileName";
        private const string FieldOUTLOOK_PROPERTY_NAME_XSL_FILE_NAME = "OUTLOOK_PROPERTY_NAME_XSL_FILE_NAME";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookSyncProperty)

        #region General Initializer : Class (OutlookSyncProperty) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OutlookSyncProperty" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodgetOutlookPropertyCollection, 0)]
        [Category("AUT Explore")]
        public void AUT_OutlookSyncProperty_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OutlookSyncProperty) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookSyncProperty" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookSyncProperty_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OutlookSyncProperty) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookSyncProperty" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldmsOutlookPropertyNameXslFullFileName)]
        [TestCase(FieldOUTLOOK_PROPERTY_NAME_XSL_FILE_NAME)]
        [Category("AUT Fields")]
        public void AUT_OutlookSyncProperty_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OutlookSyncProperty) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OutlookSyncProperty" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookSyncProperty_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}