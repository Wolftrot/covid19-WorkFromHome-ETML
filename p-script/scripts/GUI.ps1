
# Chargement des assemblies
[void][System.Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms")
[void][System.Reflection.Assembly]::LoadWithPartialName("System.Drawing")

# Creation de la form principale
$form = New-Object Windows.Forms.Form

# config-form
$form.FormBorderStyle = [System.Windows.Forms.FormBorderStyle]::FixedDialog
$form.MaximizeBox = $False
$form.Text = "MyWatch"
$form.Size = New-Object System.Drawing.Size(800,600)

# Layout-Control
$layout = New-Object Windows.Forms.LayoutPanel
$layout.Location = New-Object System.Drawing.Point(0,0)
$layout.Size = New-Object System.Drawing.Size(200,20)
$layout.Size = New-Object System.Drawing.Size(200,20)


# Label May the force be with you
$label_prez = New-Object System.Windows.Forms.Label
$label_prez.Location = New-Object System.Drawing.Point(20,20)
$label_prez.Size = New-Object System.Drawing.Size(200,20)
$label_prez.Text = "May the force be with you... Choose your side : "

# Label May the force be with you
$label = New-Object System.Windows.Forms.Label
$label.Location = New-Object System.Drawing.Point(20,40)
$label.Size = New-Object System.Drawing.Size(200,20)
$label.Text = "hjghjghjghj"

$layout.Controls.Add($label_prez);
$layout.Controls.Add($label);

$form.Controls.Add($layout);
# Affichage de la Windows
$form.ShowDialog()