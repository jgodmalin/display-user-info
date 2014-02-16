Dim cn As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Data\Db\Faculty.mdb;")
        Dim dr1 As OleDbDataReader
        Dim com As New OleDbCommand


        com.CommandText = "select [Username],[Fname],[Lname],[Mname],[NickName],[Birthday],[Adds],[City],[CounPC],[Gender],[Religion],[Citizenship],[Contact],[stats],[Fathername],[Mothername],[FMAddress],[CollCourse],[VocCourse],[ElemEd],[ElemGrad],[HighEd],[HighGrad],[CollegeEd],[CollegeGrad],[VocationalCourse],[Skills],[Company],[Company1],[Position],[Position1],[YrStart],[YrStart1] from Personal where Username = '" & mainForm.TSUname.Text & "'"
        com.Connection = cn
        If cn.State = ConnectionState.Closed Then cn.Open()

        ' Username
        Dim Username As OleDbParameter = New OleDbParameter("@Username", OleDbType.VarWChar, 50)
        Username.Value = mainForm.TSUname.Text.ToString
        com.Parameters.Add(Username)

        dr1 = com.ExecuteReader
        If dr1.Read Then
            If dr1(1) = My.Settings.CurrentUserName.ToString Then
                ' Personal Information
                tbFname.Text = dr1(1)
                tbLname.Text = dr1(2)
                tbMname.Text = dr1(3)
                lblNickname.Text = dr1(4) & "!"
                tbBday.Text = dr1(5)
                tbAdd.Text = dr1(6)
                tbCity.Text = dr1(7)
                tbCountry.Text = dr1(8)
                tbGender.Text = dr1(9)
                tbReligion.Text = dr1(10)
                tbCitizenship.Text = dr1(11)
                tbContact.Text = dr1(12)
                tbStatus.Text = dr1(13)
                ' Parents
                tbFather.Text = dr1(14)
                tbMother.Text = dr1(15)
                tbAddress.Text = dr1(16)
                'Educational Background
                tbCollCourse.Text = dr1(17)
                tbVocCourse.Text = dr1(18)
                tbElemEd.Text = dr1(19)
                tbElemGrad.Text = dr1(20)
                tbHSEd.Text = dr1(21)
                tbHSGrad.Text = dr1(22)
                tbCollED.Text = dr1(23)
                tbColGrad.Text = dr1(24)
                tbVocational.Text = dr1(25)
                tbSkill.Text = dr1(26)
                ' Employment Background
                tbCompany.Text = dr1(27)
                tbCompany1.Text = dr1(28)
                tbPosition.Text = dr1(29)
                tbPosition1.Text = dr1(30)
                tbStart.Text = dr1(31)
                tbStart1.Text = dr1(32)
            Else
                MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("UserID is Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
