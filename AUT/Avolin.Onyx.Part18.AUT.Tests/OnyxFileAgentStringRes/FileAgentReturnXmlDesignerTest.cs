using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.OnyxFileAgentStringRes
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxFileAgentStringRes.FileAgent_ReturnXml" />)
    ///     and namespace <see cref="OnyxFileAgentStringRes"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FileAgentReturnXmlDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="FileAgent_ReturnXmlNonPublicTypeName" />) using
        ///     Using a public type <see cref="OnyxFileAgentStringRes.OnyxFileAgentStringRes" /> to
        ///     create a non-public type.
        /// </summary>
        public FileAgentReturnXmlDesignerTest() : base(publicType: typeof(global::OnyxFileAgentStringRes.OnyxFileAgentStringRes), classNameWithNamespace: FileAgent_ReturnXmlNonPublicTypeName)
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

        private Type _fileAgentReturnXmlInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string FileAgent_ReturnXmlNonPublicTypeName = "OnyxFileAgentStringRes.FileAgent_ReturnXml";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _fileAgentReturnXmlInstance;
        private object _fileAgentReturnXmlInstanceFixture;

        #region General Initializer : Class (FileAgent_ReturnXml) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxFileAgentStringRes.FileAgent_ReturnXml" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fileAgentReturnXmlInstanceFixture = this.CreateNonPublicType(FileAgent_ReturnXmlNonPublicTypeName);
            _fileAgentReturnXmlInstance = _fileAgentReturnXmlInstanceFixture;
            CurrentInstance = _fileAgentReturnXmlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FileAgent_ReturnXml) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";
        private const string PropertyDebug = "Debug";
        private const string PropertyEmptyFile = "EmptyFile";
        private const string PropertyFileDataXml_Error = "FileDataXml_Error";
        private const string PropertyFileGetError = "FileGetError";
        private const string PropertyFileWriteError = "FileWriteError";
        private const string PropertyInvalid_SessionID = "Invalid_SessionID";
        private const string PropertyMissing_Extension = "Missing_Extension";
        private const string PropertyMissing_File_Name = "Missing_File_Name";
        private const string PropertyMissing_Root_Dir = "Missing_Root_Dir";
        private const string PropertyNullApplication_Name = "NullApplication_Name";
        private const string PropertyNullFileData = "NullFileData";
        private const string PropertyNullSessionID = "NullSessionID";
        private const string PropertyString1 = "String1";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (FileAgent_ReturnXml)

        #region General Initializer : Class (FileAgent_ReturnXml) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxFileAgentStringRes.FileAgent_ReturnXml" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyDebug)]
        [TestCase(PropertyEmptyFile)]
        [TestCase(PropertyFileDataXml_Error)]
        [TestCase(PropertyFileGetError)]
        [TestCase(PropertyFileWriteError)]
        [TestCase(PropertyInvalid_SessionID)]
        [TestCase(PropertyMissing_Extension)]
        [TestCase(PropertyMissing_File_Name)]
        [TestCase(PropertyMissing_Root_Dir)]
        [TestCase(PropertyNullApplication_Name)]
        [TestCase(PropertyNullFileData)]
        [TestCase(PropertyNullSessionID)]
        [TestCase(PropertyString1)]
        [Category("AUT Property")]
        public void AUT_FileAgentReturnXmlDesigner_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (FileAgent_ReturnXml) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxFileAgentStringRes.FileAgent_ReturnXml" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldresourceMan)]
        [TestCase(FieldresourceCulture)]
        [Category("AUT Fields")]
        public void AUT_FileAgentReturnXmlDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region Category : GetterSetter

        #region General Getters/Setters : Class (FileAgent_ReturnXml) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyDebug)]
        [TestCase(PropertyEmptyFile)]
        [TestCase(PropertyFileDataXml_Error)]
        [TestCase(PropertyFileGetError)]
        [TestCase(PropertyFileWriteError)]
        [TestCase(PropertyInvalid_SessionID)]
        [TestCase(PropertyMissing_Extension)]
        [TestCase(PropertyMissing_File_Name)]
        [TestCase(PropertyMissing_Root_Dir)]
        [TestCase(PropertyNullApplication_Name)]
        [TestCase(PropertyNullFileData)]
        [TestCase(PropertyNullSessionID)]
        [TestCase(PropertyString1)]
        public void AUT_FileAgentReturnXmlDesigner_Property_Exist_By_Name_Verify_Test(string name)
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

        #endregion

        #endregion
    }
}