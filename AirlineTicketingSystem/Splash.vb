Public NotInheritable Class Splash

	'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
	'  of the Project Designer ("Properties" under the "Project" menu).


	Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		'Set up the dialog text at runtime according to the application's assembly information.  

		'Format the version information using the text set into the Version control at design time as the
		'  formatting string.  This allows for effective localization if desired.
		'  Build and revision information could be included by using the following code and changing the 
		'  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
		'  String.Format() in Help for more information.
		'
		'    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

		Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

		'Copyright info
		Copyright.Text = My.Application.Info.Copyright

		'Initialize session
		App.Session = New LinkedList(Of Object)


	End Sub

	Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

	End Sub

	Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

	End Sub

	Private Sub Splash_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
	End Sub

End Class
