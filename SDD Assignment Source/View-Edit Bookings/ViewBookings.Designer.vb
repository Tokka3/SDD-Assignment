<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBookings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpBookings = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClearSearch = New FontAwesome.Sharp.IconButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxSearchCategory = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClearSort = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxSort = New System.Windows.Forms.ComboBox()
        Me.btnSort = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxMovieSelection = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFilter = New FontAwesome.Sharp.IconButton()
        Me.btnClearFilters = New FontAwesome.Sharp.IconButton()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.btnBack = New FontAwesome.Sharp.IconPictureBox()
        Me.IconMenuItem1 = New FontAwesome.Sharp.IconMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnHelp = New FontAwesome.Sharp.IconPictureBox()
        Me.gpInsights = New System.Windows.Forms.GroupBox()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblTotalBookings = New System.Windows.Forms.Label()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpInsights.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBookings
        '
        Me.grpBookings.Location = New System.Drawing.Point(33, 128)
        Me.grpBookings.Name = "grpBookings"
        Me.grpBookings.Size = New System.Drawing.Size(741, 504)
        Me.grpBookings.TabIndex = 14
        Me.grpBookings.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(2)
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2)
        Me.Label2.Size = New System.Drawing.Size(27, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(183, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(2)
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(383, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(2)
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Seats:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(548, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(2)
        Me.Label5.Size = New System.Drawing.Size(43, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(65, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(907, 78)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "View/Edit Bookings"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnClearSearch)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxSearchCategory)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(780, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 170)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Enter Search Keyword(s):"
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.ForeColor = System.Drawing.Color.White
        Me.btnClearSearch.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnClearSearch.IconColor = System.Drawing.Color.White
        Me.btnClearSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearSearch.IconSize = 22
        Me.btnClearSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearSearch.Location = New System.Drawing.Point(101, 132)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(125, 30)
        Me.btnClearSearch.TabIndex = 24
        Me.btnClearSearch.Text = "Clear Search"
        Me.btnClearSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearSearch.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Search Category:"
        '
        'cbxSearchCategory
        '
        Me.cbxSearchCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSearchCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxSearchCategory.FormattingEnabled = True
        Me.cbxSearchCategory.Items.AddRange(New Object() {"All", "ID", "First Name", "Last Name"})
        Me.cbxSearchCategory.Location = New System.Drawing.Point(6, 42)
        Me.cbxSearchCategory.Name = "cbxSearchCategory"
        Me.cbxSearchCategory.Size = New System.Drawing.Size(221, 29)
        Me.cbxSearchCategory.TabIndex = 19
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnSearch.IconColor = System.Drawing.Color.White
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 22
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSearch.Location = New System.Drawing.Point(6, 133)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 29)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(6, 98)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(221, 29)
        Me.txtSearch.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Enter what you would like to find.")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClearSort)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbxSort)
        Me.GroupBox2.Controls.Add(Me.btnSort)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(780, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 124)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sort"
        '
        'btnClearSort
        '
        Me.btnClearSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnClearSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSort.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSort.ForeColor = System.Drawing.Color.White
        Me.btnClearSort.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnClearSort.IconColor = System.Drawing.Color.White
        Me.btnClearSort.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearSort.IconSize = 22
        Me.btnClearSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearSort.Location = New System.Drawing.Point(105, 80)
        Me.btnClearSort.Name = "btnClearSort"
        Me.btnClearSort.Size = New System.Drawing.Size(122, 30)
        Me.btnClearSort.TabIndex = 26
        Me.btnClearSort.Text = "Default Sort"
        Me.btnClearSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnClearSort, "Sort by ID (ascending)")
        Me.btnClearSort.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Sort By:"
        '
        'cbxSort
        '
        Me.cbxSort.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxSort.FormattingEnabled = True
        Me.cbxSort.Items.AddRange(New Object() {"ID (Ascending) [Default]", "ID (Descending)", "First Name (A-Z)", "First Name (Z-A)", "Last Name (A-Z)", "Last Name (Z-A)", "Price (Ascending)", "Price (Descending)"})
        Me.cbxSort.Location = New System.Drawing.Point(6, 45)
        Me.cbxSort.Name = "cbxSort"
        Me.cbxSort.Size = New System.Drawing.Size(221, 29)
        Me.cbxSort.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.cbxSort, "Display records in a certain order. ")
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSort.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.ForeColor = System.Drawing.Color.White
        Me.btnSort.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown
        Me.btnSort.IconColor = System.Drawing.Color.White
        Me.btnSort.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSort.IconSize = 25
        Me.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSort.Location = New System.Drawing.Point(6, 80)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(89, 29)
        Me.btnSort.TabIndex = 21
        Me.btnSort.Text = "Sort"
        Me.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(6, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Film:"
        '
        'cbxMovieSelection
        '
        Me.cbxMovieSelection.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMovieSelection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxMovieSelection.FormattingEnabled = True
        Me.cbxMovieSelection.Items.AddRange(New Object() {"All", "Good Will Hunting", "The Lion King", "Forrest Gump"})
        Me.cbxMovieSelection.Location = New System.Drawing.Point(6, 44)
        Me.cbxMovieSelection.Name = "cbxMovieSelection"
        Me.cbxMovieSelection.Size = New System.Drawing.Size(221, 29)
        Me.cbxMovieSelection.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.cbxMovieSelection, "Only display records with this film.")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(282, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(2)
        Me.Label10.Size = New System.Drawing.Size(38, 21)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Film:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnFilter)
        Me.GroupBox3.Controls.Add(Me.btnClearFilters)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbxMovieSelection)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(780, 415)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 116)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter"
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.btnFilter.IconColor = System.Drawing.Color.White
        Me.btnFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFilter.IconSize = 25
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.Location = New System.Drawing.Point(6, 79)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(93, 29)
        Me.btnFilter.TabIndex = 27
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnClearFilters
        '
        Me.btnClearFilters.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilters.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearFilters.ForeColor = System.Drawing.Color.White
        Me.btnClearFilters.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnClearFilters.IconColor = System.Drawing.Color.White
        Me.btnClearFilters.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearFilters.IconSize = 22
        Me.btnClearFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearFilters.Location = New System.Drawing.Point(105, 79)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(125, 30)
        Me.btnClearFilters.TabIndex = 26
        Me.btnClearFilters.Text = "Clear Filters"
        Me.btnClearFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnClearFilters, "Remove film filter on all records.")
        Me.btnClearFilters.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.btnRefresh.IconColor = System.Drawing.Color.White
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 28
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.Location = New System.Drawing.Point(683, 96)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(91, 32)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.btnBack.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnBack.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBack.IconSize = 41
        Me.btnBack.Location = New System.Drawing.Point(13, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 13
        Me.btnBack.TabStop = False
        '
        'IconMenuItem1
        '
        Me.IconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMenuItem1.IconColor = System.Drawing.Color.Black
        Me.IconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMenuItem1.Name = "IconMenuItem1"
        Me.IconMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.IconMenuItem1.Text = "IconMenuItem1"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnHelp.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnHelp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHelp.IconSize = 41
        Me.btnHelp.Location = New System.Drawing.Point(970, 9)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(46, 41)
        Me.btnHelp.TabIndex = 28
        Me.btnHelp.TabStop = False
        '
        'gpInsights
        '
        Me.gpInsights.Controls.Add(Me.lblTotalBookings)
        Me.gpInsights.Controls.Add(Me.lblRevenue)
        Me.gpInsights.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpInsights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.gpInsights.Location = New System.Drawing.Point(780, 537)
        Me.gpInsights.Name = "gpInsights"
        Me.gpInsights.Size = New System.Drawing.Size(236, 95)
        Me.gpInsights.TabIndex = 28
        Me.gpInsights.TabStop = False
        Me.gpInsights.Text = "Insights"
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblRevenue.Location = New System.Drawing.Point(6, 25)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(73, 21)
        Me.lblRevenue.TabIndex = 27
        Me.lblRevenue.Text = "Revenue:"
        '
        'lblTotalBookings
        '
        Me.lblTotalBookings.AutoSize = True
        Me.lblTotalBookings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBookings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTotalBookings.Location = New System.Drawing.Point(6, 56)
        Me.lblTotalBookings.Name = "lblTotalBookings"
        Me.lblTotalBookings.Size = New System.Drawing.Size(113, 21)
        Me.lblTotalBookings.TabIndex = 28
        Me.lblTotalBookings.Text = "Total Bookings:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExit.IconColor = System.Drawing.Color.White
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 22
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.Location = New System.Drawing.Point(937, 638)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 30)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "EXIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnExit, "Remove film filter on all records.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ViewBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 674)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gpInsights)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpBookings)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ViewBookings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewBookings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpInsights.ResumeLayout(False)
        Me.gpInsights.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents btnBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents grpBookings As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxSearchCategory As ComboBox
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents IconMenuItem1 As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSort As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxSort As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxMovieSelection As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClearSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClearSort As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClearFilters As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnHelp As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents gpInsights As GroupBox
    Friend WithEvents lblTotalBookings As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
End Class
