<?xml version="1.0" encoding="UTF-8"?>
<tileset version="1.5" tiledversion="1.5.0" name="Grass and Dirt" tilewidth="16" tileheight="16" tilecount="528" columns="12">
 <image source="../Art/tileset_basic_terrain.png" trans="000000" width="192" height="704"/>
 <tile id="72">
  <animation>
   <frame tileid="72" duration="350"/>
   <frame tileid="73" duration="350"/>
   <frame tileid="85" duration="350"/>
   <frame tileid="84" duration="350"/>
  </animation>
 </tile>
 <wangsets>
  <wangset name="Trail" type="mixed" tile="-1">
   <wangcolor name="dirt and empty" color="#ff0000" tile="-1" probability="1"/>
   <wangtile tileid="108" wangid="1,1,1,0,1,1,1,1"/>
   <wangtile tileid="109" wangid="1,1,1,0,0,0,1,1"/>
   <wangtile tileid="110" wangid="1,1,1,1,1,0,1,1"/>
   <wangtile tileid="120" wangid="1,0,0,0,1,1,1,1"/>
   <wangtile tileid="122" wangid="1,1,1,1,1,0,0,0"/>
   <wangtile tileid="132" wangid="1,0,1,1,1,1,1,1"/>
   <wangtile tileid="133" wangid="0,0,1,1,1,1,1,0"/>
   <wangtile tileid="134" wangid="1,1,1,1,1,1,1,0"/>
   <wangtile tileid="144" wangid="0,0,1,1,1,0,0,0"/>
   <wangtile tileid="145" wangid="0,0,1,1,1,1,1,0"/>
   <wangtile tileid="146" wangid="0,0,0,0,1,1,1,0"/>
   <wangtile tileid="156" wangid="1,1,1,1,1,0,0,0"/>
   <wangtile tileid="157" wangid="1,1,1,1,1,1,1,1"/>
   <wangtile tileid="158" wangid="1,0,0,0,1,1,1,1"/>
   <wangtile tileid="168" wangid="1,1,1,0,0,0,0,0"/>
   <wangtile tileid="169" wangid="1,1,1,0,0,0,1,1"/>
   <wangtile tileid="170" wangid="1,0,0,0,0,0,1,1"/>
  </wangset>
 </wangsets>
</tileset>
