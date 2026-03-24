// WorkflowConfig.cs

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WpfDragDropFramework
{{
    [XmlRoot("WorkflowConfig")]
    public class WorkflowConfig
    {{
        [XmlElement("Workflows")]
        public List<Workflow> Workflows { get; set; }

        [XmlElement("Version")]
        public string Version { get; set; }

        public WorkflowConfig()
        {{
            Workflows = new List<Workflow>();
        }}
    }}

    public class Workflow
    {{
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Steps")]
        public List<string> Steps { get; set; }

        public Workflow()
        {{
            Steps = new List<string>();
        }}
    }}
}}