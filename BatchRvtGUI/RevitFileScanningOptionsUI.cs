﻿//
// Revit Batch Processor
//
// Copyright (c) 2020  Daniel Rumery, BVN
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
//

using System.Windows.Forms;
using BatchRvtUtil;

namespace BatchRvtGUI;

public partial class RevitFileScanningOptionsUI : Form
{
    public RevitFileScanningOptionsUI()
    {
        InitializeComponent();
    }

    public RevitFileScanning.RevitFileType GetSelectedRevitFileType()
    {
        var revitFileType = RevitFileScanning.RevitFileType.Project;

        if (projectFilesRadioButton.Checked)
            revitFileType = RevitFileScanning.RevitFileType.Project;
        else if (familyFilesRadioButton.Checked)
            revitFileType = RevitFileScanning.RevitFileType.Family;
        else if (revitFilesRadioButton.Checked) revitFileType = RevitFileScanning.RevitFileType.ProjectAndFamily;

        return revitFileType;
    }

    public bool IncludeSubfolders()
    {
        return includeSubfoldersCheckBox.Checked;
    }

    public bool ExpandNetworkPaths()
    {
        return expandNetworkPathsCheckBox.Checked;
    }

    public bool ExtractRevitVersionInfo()
    {
        return detectRevitFileVersionCheckBox.Checked;
    }

    public bool IgnoreRevitBackupFiles()
    {
        return ignoreBackupFilesCheckBox.Checked;
    }
}