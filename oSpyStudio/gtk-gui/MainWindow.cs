// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action FileAction;
    
    private Gtk.Action OpenAction;
    
    private Gtk.Action QuitAction;
    
    private Gtk.VBox rootBox;
    
    private Gtk.MenuBar menubar;
    
    private Gtk.Label dummyLabel;
    
    private Gtk.Statusbar statusbar;
    
    private Gtk.ProgressBar progressbar;
    
    private Gtk.Button cancelButton;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("_File"), null, null);
        this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("_File");
        w1.Add(this.FileAction, null);
        this.OpenAction = new Gtk.Action("OpenAction", Mono.Unix.Catalog.GetString("_Open..."), null, "gtk-open");
        this.OpenAction.ShortLabel = Mono.Unix.Catalog.GetString("_Open...");
        w1.Add(this.OpenAction, null);
        this.QuitAction = new Gtk.Action("QuitAction", Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-quit");
        this.QuitAction.ShortLabel = Mono.Unix.Catalog.GetString("_Quit");
        w1.Add(this.QuitAction, null);
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.rootBox = new Gtk.VBox();
        this.rootBox.Name = "rootBox";
        this.rootBox.Spacing = 6;
        // Container child rootBox.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><menubar name='menubar'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/><separator/><menuitem name='QuitAction' action='QuitAction'/></menu></menubar></ui>");
        this.menubar = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar")));
        this.menubar.Name = "menubar";
        this.rootBox.Add(this.menubar);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.rootBox[this.menubar]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child rootBox.Gtk.Box+BoxChild
        this.dummyLabel = new Gtk.Label();
        this.dummyLabel.Name = "dummyLabel";
        this.rootBox.Add(this.dummyLabel);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.rootBox[this.dummyLabel]));
        w3.Position = 1;
        w3.Fill = false;
        // Container child rootBox.Gtk.Box+BoxChild
        this.statusbar = new Gtk.Statusbar();
        this.statusbar.Name = "statusbar";
        this.statusbar.Spacing = 6;
        // Container child statusbar.Gtk.Box+BoxChild
        this.progressbar = new Gtk.ProgressBar();
        this.progressbar.Name = "progressbar";
        this.statusbar.Add(this.progressbar);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.statusbar[this.progressbar]));
        w4.Position = 1;
        w4.Expand = false;
        // Container child statusbar.Gtk.Box+BoxChild
        this.cancelButton = new Gtk.Button();
        this.cancelButton.CanFocus = true;
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.UseStock = true;
        this.cancelButton.UseUnderline = true;
        this.cancelButton.Label = "gtk-cancel";
        this.statusbar.Add(this.cancelButton);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.statusbar[this.cancelButton]));
        w5.Position = 2;
        w5.Expand = false;
        w5.Fill = false;
        this.rootBox.Add(this.statusbar);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.rootBox[this.statusbar]));
        w6.Position = 2;
        w6.Expand = false;
        w6.Fill = false;
        this.Add(this.rootBox);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 612;
        this.DefaultHeight = 333;
        this.progressbar.Hide();
        this.cancelButton.Hide();
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.OpenAction.Activated += new System.EventHandler(this.OpenAction_Activated);
        this.QuitAction.Activated += new System.EventHandler(this.QuitAction_Activated);
    }
}
