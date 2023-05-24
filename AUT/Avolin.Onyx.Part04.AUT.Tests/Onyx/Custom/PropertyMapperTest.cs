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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.PropertyMapper" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PropertyMapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="PropertyMapperNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public PropertyMapperTest() : base(publicType: typeof(Common), classNameWithNamespace: PropertyMapperNonPublicTypeName)
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

        private Type _propertyMapperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string PropertyMapperNonPublicTypeName = "Onyx.Custom.PropertyMapper";

        #region General Initializer : Class (PropertyMapper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="PropertyMapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PropertyMapper) Initializer

        #region Methods

        private const string MethodcreateFieldSetKvP = "createFieldSetKvP";
        private const string MethodgetFieldsFromCollection = "getFieldsFromCollection";
        private const string MethodfieldSetFromIndividual = "fieldSetFromIndividual";
        private const string MethodgetBiDirectionalSyncObjects = "getBiDirectionalSyncObjects";
        private const string MethodLoadIndividual = "LoadIndividual";
        private const string MethodLoadAddresses = "LoadAddresses";
        private const string MethodLoadPhones = "LoadPhones";
        private const string MethodLoadEmailAddresses = "LoadEmailAddresses";
        private const string MethodcreateLogicalObjects = "createLogicalObjects";
        private const string MethoddeleteCollectionItem = "deleteCollectionItem";
        private const string MethodgetOutlookValue = "getOutlookValue";
        private const string MethodresolveValueToMaster = "resolveValueToMaster";
        private const string MethodsetAttribute = "setAttribute";

        #endregion

        #region Fields

        private const string Field_dInParams = "_dInParams";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (PropertyMapper)

        #region General Initializer : Class (PropertyMapper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PropertyMapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodcreateFieldSetKvP, 0)]
        [TestCase(MethodgetFieldsFromCollection, 0)]
        [TestCase(MethodfieldSetFromIndividual, 0)]
        [TestCase(MethodgetBiDirectionalSyncObjects, 0)]
        [TestCase(MethodLoadIndividual, 0)]
        [TestCase(MethodLoadAddresses, 0)]
        [TestCase(MethodLoadPhones, 0)]
        [TestCase(MethodLoadEmailAddresses, 0)]
        [TestCase(MethodcreateLogicalObjects, 0)]
        [TestCase(MethoddeleteCollectionItem, 0)]
        [TestCase(MethodgetOutlookValue, 0)]
        [TestCase(MethodresolveValueToMaster, 0)]
        [TestCase(MethodsetAttribute, 0)]
        [Category("AUT Explore")]
        public void AUT_PropertyMapper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (PropertyMapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PropertyMapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PropertyMapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (PropertyMapper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PropertyMapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_dInParams)]
        [Category("AUT Fields")]
        public void AUT_PropertyMapper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (PropertyMapper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PropertyMapper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PropertyMapper_Explore_Reflection_Based_NonListed_Fields_Test()
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