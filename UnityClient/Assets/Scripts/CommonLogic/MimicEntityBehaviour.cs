﻿//using System;
//using System.Collections.Generic;

//using UnityEngine;

//using GameLogic;
//using Railgun;

//public class GameEntityMimic : MonoBehaviour
//{
//  public GameMimic Entity { get; set; }
//  public Color color = Color.white;

//  private static Vector2 GetCoordinates(RailState state)
//  {
//    GameState demoState = (GameState)state;
//    return new Vector2(demoState.X, demoState.Y);
//  }

//  void Start()
//  {
//    this.Entity.Frozen += this.OnFrozen;
//    this.Entity.Unfrozen += this.OnUnfrozen;
//  }

//  void Update()
//  {
//    if (this.Entity != null)
//      this.UpdatePosition();
//  }

//  private void UpdatePosition()
//  {
//    GameState state = this.Entity.State;
//    //if (Client.DoSmoothing)
//    //  state = this.Entity.GetSmoothedState(Time.time - Time.fixedTime);
//    this.transform.position =
//      new Vector2(state.X, state.Y);
//  }

//  private void OnFrozen()
//  {
//    this.gameObject.SetActive(false);
//  }

//  private void OnUnfrozen()
//  {
//    this.gameObject.SetActive(true);
//  }
//}
