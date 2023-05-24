using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxDictionaryDAC;
using Shouldly;

namespace Avolin.Onyx.Part05.AUT.Tests.OnyxDictionaryDAC
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.ObjectInfo" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ObjectInfoTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ObjectInfoNonPublicTypeName" />) using
        ///     Using a public type <see cref="Dictionary" /> to
        ///     create a non-public type.
        /// </summary>
        public ObjectInfoTest() : base(publicType: typeof(Dictionary), classNameWithNamespace: ObjectInfoNonPublicTypeName)
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

        private Type _objectInfoInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ObjectInfoNonPublicTypeName = "OnyxDictionaryDAC.ObjectInfo";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _objectInfoInstance;
        private object _objectInfoInstanceFixture;

        #region General Initializer : Class (ObjectInfo) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ObjectInfo" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _objectInfoInstanceFixture = this.CreateNonPublicType(ObjectInfoNonPublicTypeName);
            _objectInfoInstance = _objectInfoInstanceFixture;
            CurrentInstance = _objectInfoInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ObjectInfo) Initializer

        #region Fields

        private const string FieldmsObjectID = "msObjectID";
        private const string FieldmsName = "msName";
        private const string FieldmbValid = "mbValid";
        private const string FieldmbDisabled = "mbDisabled";
        private const string FieldmbReferencesValid = "mbReferencesValid";
        private const string FieldmbReferencesChecked = "mbReferencesChecked";
        private const string FieldmbObjectChanged = "mbObjectChanged";
        private const string FieldmsDefinitionType = "msDefinitionType";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ObjectInfo)

        #region General Initializer : Class (ObjectInfo) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ObjectInfo" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldmsObjectID)]
        [TestCase(FieldmsName)]
        [TestCase(FieldmbValid)]
        [TestCase(FieldmbDisabled)]
        [TestCase(FieldmbReferencesValid)]
        [TestCase(FieldmbReferencesChecked)]
        [TestCase(FieldmbObjectChanged)]
        [TestCase(FieldmsDefinitionType)]
        [Category("AUT Fields")]
        public void AUT_ObjectInfo_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ObjectInfo) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ObjectInfo" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ObjectInfo_Explore_Reflection_Based_NonListed_Fields_Test()
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