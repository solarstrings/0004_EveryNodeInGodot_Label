using Godot;
using System;

public class Main : Node2D
{
    private Label MyLabel;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        MyLabel = GetNode<Label>("Label");
        MyLabel.Text = "I am a label and I'm Happy!";
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
