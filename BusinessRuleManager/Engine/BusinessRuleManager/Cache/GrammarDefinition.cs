// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using System.Reflection;

namespace ConsonaCRM.BusinessRuleManager.Cache
{
	/// <summary>
	/// Contains grammar definition details for a grammar item.
	/// </summary>
	public class GrammarDefinition
	{
		#region Private fields
		private string m_name;
		private string m_className;
		private string m_moduleName;
		private AssemblyName m_assemblyName;
		private Type m_type;
		#endregion

		#region Public properties
		/// <summary>
		/// Name of the grammar item.
		/// </summary>
		public string name
		{
			get
			{
				return m_name;
			}
			set
			{
				m_name = value;
			}
		}
		/// <summary>
		/// Full name of the class mapped to the grammar item.
		/// </summary>
		public string className
		{
			get
			{
				return m_className;
			}
			set
			{
				m_className = value;
			}
		}
		/// <summary>
		/// Module name mapped to the grammar item.
		/// </summary>
		public string moduleName
		{
			get
			{
				return m_moduleName;
			}
			set
			{
				m_moduleName = value;
			}
		}
		/// <summary>
		/// Full name of the assembly mapped to the grammar item.
		/// </summary>
		public AssemblyName assemblyName
		{
			get
			{
				return m_assemblyName;
			}
			set
			{
				m_assemblyName = value;
			}
		}
		/// <summary>
		/// Type of the class mapped to the grammar item.
		/// </summary>
		public Type type
		{
			get
			{
				return m_type;
			}
			set
			{
				m_type = value;
			}
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Deserialise a grammar definition XML node into a GrammarDefinition object.
		/// </summary>
		/// <param name="definitionNode">XML node containing grammar definition.</param>
		/// <returns>GrammarDefinition object.</returns>
		public static GrammarDefinition Deserialise(XmlNode definitionNode)
		{
			// Create definition object
			GrammarDefinition definition = new GrammarDefinition();

			// Get attribute values from XML definition
			definition.name = definitionNode.Attributes.GetNamedItem("name").InnerText;
			definition.className = definitionNode.Attributes.GetNamedItem("class").InnerText;
			definition.moduleName = definitionNode.Attributes.GetNamedItem("module").InnerText;

			// Get full assembly name
			string name = Assembly.GetExecutingAssembly().Location;
			name = name.Remove(name.LastIndexOf("\\") + 1);
			name += definitionNode.SelectSingleNode("//module[@name='" + definition.moduleName + "']").Attributes.GetNamedItem("assembly").InnerText;
			name += ".dll";
			definition.assemblyName = AssemblyName.GetAssemblyName(name);

			// Load assembly, get type
			Assembly thisAssembly = Assembly.Load(definition.assemblyName);
			definition.type = thisAssembly.GetType(definition.className);
			if (definition.type == null)
			{
				string assemblyClassName = MethodBase.GetCurrentMethod().DeclaringType.Name;
				throw new BusinessRuleManagerException(assemblyClassName,
					(long)SystemMessage.MessageId.UnknownClassType,
					definition.className,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Return definition object
			return definition;
		}
		/// <summary>
		/// Determines if the type mapped to the grammar item implements
		/// the provided interface.
		/// </summary>
		/// <param name="pInterfaceType">System.Type of the interface.</param>
		/// <returns>true if the interface is implemented.</returns>
		public bool ImplementsInterface(Type pInterfaceType)
		{
			return (this.type.GetInterface(pInterfaceType.FullName) != null);
		}
		#endregion
	}
}
