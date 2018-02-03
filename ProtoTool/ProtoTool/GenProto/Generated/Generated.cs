using System;
using System.Collections.Generic;

namespace Example
{
    public partial class C2sActivityBaseui
    {
        /// <summary>获取活动大厅界面信息</summary>
        public int PlaceHolder { get; set; }

    }

    public partial class ActivityOneui
    {
        public int ActId { get; set; }

        public int Type { get; set; }

        /// <summary>1开启中,2待开启</summary>
        public int? ExcActid { get; set; }

    }

    public partial class ActivityEveryday
    {
        public int EdId { get; set; }

        public int Rcnt { get; set; }

        /// <summary>当前剩余次数</summary>
        public int? HasBuy { get; set; }

    }

    public partial class S2cActivityBaseui
    {
        public List<global::Example.ActivityOneui> Ainfo { get; set; }

        public List<global::Example.ActivityEveryday> Edinfo { get; set; }

        public List<int> Ginfo { get; set; }

    }

    public partial class C2sActivityIcon
    {
        /// <summary>获取图标信息</summary>
        public int PlaceHolder { get; set; }

    }

    public partial class ActivityOneicon
    {
        public int ActId { get; set; }

        public int Stime { get; set; }

        /// <summary>开启时间</summary>
        public int Etime { get; set; }

        /// <summary>结束时间</summary>
        public int? ExcActid { get; set; }

    }

    public partial class S2cActivityIcon
    {
        /// <summary>获取图标信息</summary>
        public int Ntime { get; set; }

        /// <summary>当前时间		//lua 中的os.time()</summary>
        public List<global::Example.ActivityOneicon> Actinfo { get; set; }

        /// <summary>活动中的</summary>
        public List<global::Example.ActivityOneicon> Nextinfo { get; set; }

    }

    public partial class C2sActivityBattle
    {
        public int PlaceHolder { get; set; }

    }

    public partial class ActivityOneBattle
    {
        public int ActId { get; set; }

        public int Type { get; set; }

    }

    public partial class S2cActivityBattle
    {
        public List<global::Example.ActivityOneBattle> Binfo { get; set; }

    }

    public partial class S2cAoiSyncInt
    {
        public string Rid { get; set; }

        public string Key { get; set; }

        /// <summary>key</summary>
        public int Value { get; set; }

    }

    public partial class S2cAoiSyncRepeatint
    {
        public string Rid { get; set; }

        public string Key { get; set; }

        /// <summary>key</summary>
        public List<int> Value { get; set; }

    }

    public partial class S2cAoiSyncString
    {
        /// <summary>信息字符串</summary>
        public string Rid { get; set; }

        public string Key { get; set; }

        /// <summary>key</summary>
        public string Value { get; set; }

    }

    public partial class AoiBuffTime
    {
        public int Buffid { get; set; }

        public int StartFrame { get; set; }

        /// <summary>开始的帧</summary>
        public int ConFrame { get; set; }

    }

    public partial class S2cAoiBuffTime
    {
        public string Rid { get; set; }

        public int SFrame { get; set; }

        /// <summary>服务端当前帧</summary>
        public int SecFrame { get; set; }

        /// <summary>1秒多少帧</summary>
        public List<global::Example.AoiBuffTime> Binfo { get; set; }

    }

    public partial class S2cAoiPlayershield
    {
        public string Id { get; set; }

        public int? ShieldHp { get; set; }

        /// <summary>护盾血量</summary>
        public int? ShieldHpmax { get; set; }

        /// <summary>护盾最大血量</summary>
        public int? ShieldBuffid { get; set; }

    }

    public partial class S2cAoiSyncplayer
    {
        public string Rid { get; set; }

        public string Name { get; set; }

        public int Grade { get; set; }

        public int Shape { get; set; }

        public int Speed { get; set; }

        public int Dir360 { get; set; }

        public int? Weapon { get; set; }

        /// <summary>武器编号</summary>
        public int? Setno { get; set; }

        /// <summary>套装编号</summary>
        public int? Fashion { get; set; }

        /// <summary>时装编号</summary>
        public string Teamids { get; set; }

        /// <summary>如果有,第一个肯定是队长,例如	3;4;2</summary>
        public int Comp { get; set; }

        /// <summary>阵营</summary>
        public List<int> Buff { get; set; }

        public string Adname { get; set; }

        public string Extend { get; set; }

        public string Magic { get; set; }

        /// <summary>id;shape	法器(灵器)</summary>
        public string Partner { get; set; }

        /// <summary>id;shape	伙伴</summary>
        public string Pkinfo { get; set; }

        /// <summary>pkmode=;[team_id=;][club_id=;][evil_state][server_id=;][hostileclub=;]</summary>
        public int Sex { get; set; }

        public int? UpMount { get; set; }

        /// <summary>主角上下马状态  1上马 0下马</summary>
        public int? LingqinModel { get; set; }

        /// <summary>灵琴外形编号</summary>
        public int? LingyiModel { get; set; }

        /// <summary>灵翼外形编号</summary>
        public int? PartnerhorseModel { get; set; }

        /// <summary>灵骑外形编号(灵宝)</summary>
        public int? PetModel { get; set; }

        /// <summary>宠物外形编号</summary>
        public int? ShenjianModel { get; set; }

        /// <summary>神剑外形编号</summary>
        public int? ShenyiModel { get; set; }

        /// <summary>神翼外形编号</summary>
        public int? MountModel { get; set; }

        /// <summary>坐骑外形编号</summary>
        public int? JingmaiModel { get; set; }

        /// <summary>经脉外形编号</summary>
        public int? UpHorse { get; set; }

        /// <summary>伙伴上下马状态  1上马 0下马</summary>
        public int? Score { get; set; }

        public int? Dazuo { get; set; }

        /// <summary>打坐</summary>
        public int? Isyunbiao { get; set; }

        /// <summary>运镖标志位</summary>
        public string Clubname { get; set; }

        /// <summary>帮派名字</summary>
        public string Clubpost { get; set; }

        /// <summary>帮派职位</summary>
        public int? LingqinModelState { get; set; }

        /// <summary>灵琴外形 显示1 隐藏0</summary>
        public int? LingyiModelState { get; set; }

        /// <summary>灵翼外形 显示1 隐藏0</summary>
        public int? PartnerhorseModelState { get; set; }

        /// <summary>灵骑外形 显示1 隐藏0</summary>
        public int? PetModelState { get; set; }

        /// <summary>宠物外形 显示1 隐藏0</summary>
        public int? ShenjianModelState { get; set; }

        /// <summary>神剑外形 显示1 隐藏0</summary>
        public int? ShenyiModelState { get; set; }

        /// <summary>神翼外形 显示1 隐藏0</summary>
        public int? MagicModelState { get; set; }

        /// <summary>法器(灵器) 显示1 隐藏0</summary>
        public int? PartnerModelState { get; set; }

        /// <summary>伙伴 显示1 隐藏0</summary>
        public int? Vip { get; set; }

        /// <summary>vip</summary>
        public int? DoubleXiulian { get; set; }

        /// <summary>双修</summary>
        public int? Title { get; set; }

        /// <summary>称号</summary>
        public int? DxEffect { get; set; }

        /// <summary>双修特效 客户端要求显示</summary>
        public int? Photo { get; set; }

        /// <summary>头像</summary>
        public int? DxDir360 { get; set; }

        /// <summary>双修人物朝向</summary>
        public global::Example.S2cAoiBuffTime Btime { get; set; }

        /// <summary>倒计时的buff显示</summary>
        public string Matename { get; set; }

        /// <summary>伴侣名字</summary>
        public int? Weddingshapestate { get; set; }

        /// <summary>婚礼游行时玩家角色模型状态是否隐藏 显示0 隐藏1</summary>
        public int? Multikill { get; set; }

        public int? ShieldHp { get; set; }

        /// <summary>护盾血量</summary>
        public int? ShieldHpmax { get; set; }

        /// <summary>护盾最大血量</summary>
        public int? ShieldBuffid { get; set; }

        /// <summary>护盾id编号</summary>
        public string Enemyname { get; set; }

        /// <summary>仇人克星</summary>
        public int? Siegewar { get; set; }

    }

    public partial class S2cAoiSyncnpc
    {
        public string Rid { get; set; }

        public string Name { get; set; }

        public int Grade { get; set; }

        public int Shape { get; set; }

        public int Dir { get; set; }

        public int Canattk { get; set; }

        /// <summary>1可以攻击的,0不可以攻击的</summary>
        public int Comp { get; set; }

        /// <summary>阵营</summary>
        public List<int> Buff { get; set; }

        public string Extend { get; set; }

        public int? ShieldHp { get; set; }

        /// <summary>护盾血量</summary>
        public int? ShieldHpmax { get; set; }

        /// <summary>护盾最大血量</summary>
        public int? ShieldBuffid { get; set; }

        /// <summary>护盾id编号</summary>
        public int? Score { get; set; }

        public global::Example.S2cAoiBuffTime Btime { get; set; }

        /// <summary>倒计时的buff显示</summary>
        public List<string> Clublist { get; set; }

        /// <summary>同盟帮派列表</summary>
        public int? Siegewar { get; set; }

    }

    public partial class AoiAddNormalmsg
    {
        public int MapNo { get; set; }

        public int MapId { get; set; }

        public string Rid { get; set; }

        public int X { get; set; }

        public float Y { get; set; }

        public int Z { get; set; }

        public int Hp { get; set; }

        public int Hpmax { get; set; }

        public int CharNo { get; set; }

    }

    public partial class S2cAoiAddplayer
    {
        public global::Example.AoiAddNormalmsg Nmsg { get; set; }

        public global::Example.S2cAoiSyncplayer Sync { get; set; }

    }

    public partial class S2cAoiAddself
    {
        public global::Example.AoiAddNormalmsg Nmsg { get; set; }

        public global::Example.S2cAoiSyncplayer Sync { get; set; }

    }

    public partial class S2cAoiAddnpc
    {
        public global::Example.AoiAddNormalmsg Nmsg { get; set; }

        public global::Example.S2cAoiSyncnpc Sync { get; set; }

    }

    public partial class S2cAoiMove
    {
        /// <summary>主城移动同步协议</summary>
        public string Rid { get; set; }

        public int X { get; set; }

        public float Y { get; set; }

        public int Z { get; set; }

        public float? Speed { get; set; }

        /// <summary>移动到这点的时间</summary>
        public int? Type { get; set; }

    }

    public partial class S2cAoiLeave
    {
        public int MapNo { get; set; }

        public int MapId { get; set; }

        public string Rid { get; set; }

    }

    public partial class S2cAoiMoveError
    {
        public int Ox { get; set; }

        public float Oy { get; set; }

        public int Oz { get; set; }

    }

    public partial class S2cAoiJump
    {
        /// <summary>在同场景中跳转用(非技能跳跃)</summary>
        public int MapNo { get; set; }

        public int MapId { get; set; }

        public string Rid { get; set; }

        public int X { get; set; }

        public float Y { get; set; }

        public int Z { get; set; }

    }

    public partial class C2sAoiConveyDoor
    {
        /// <summary>到达传送门</summary>
        public int NowMapid { get; set; }

        public int NowMapno { get; set; }

        public int ToMapno { get; set; }

        public int Doorno { get; set; }

        public int? ToMapid { get; set; }

    }

    public partial class S2cAoiHp
    {
        public string AttId { get; set; }

        /// <summary>如果att_id为0则为系统加血扣血</summary>
        public string Id { get; set; }

        public int Hp { get; set; }

        /// <summary>显示血量的</summary>
        public int Nhp { get; set; }

        /// <summary>当前血量</summary>
        public int HpMax { get; set; }

        /// <summary>最大血量</summary>
        public int Type { get; set; }

        /// <summary>hp扣血加血方式    0:普通伤害(加血),1:暴击伤害,2:破格伤害,3:暴击破格伤害,4:miss,5:无敌</summary>
        public int Isdie { get; set; }

        /// <summary>1是,0否</summary>
        public int? Htype { get; set; }

        /// <summary>灵宠1,法器2</summary>
        public int? DieX { get; set; }

        /// <summary>死亡格子坐标</summary>
        public int? DieY { get; set; }

        /// <summary>死亡格子坐标</summary>
        public int? Shpstamp { get; set; }

    }

    public partial class C2sAoiSkillAct
    {
        /// <summary>技能开始广播</summary>
        public int SkillId { get; set; }

        public string TarId { get; set; }

        public int? Tx { get; set; }

        /// <summary>如果是aoe,有时候是没有目标点释放的,就需要有个释放点</summary>
        public int? Ty { get; set; }

        /// <summary>如果是aoe,有时候是没有目标点释放的,就需要有个释放点</summary>
        public string Axyz { get; set; }

        /// <summary>直接转发</summary>
        public int Sx { get; set; }

        /// <summary>施法者坐标</summary>
        public int Sz { get; set; }

        public int? Timestamp { get; set; }

    }

    public partial class AoiSkillCalinfo
    {
        public string CalId { get; set; }

        public string AttId { get; set; }

        public int SRid { get; set; }

        /// <summary>技能运行id</summary>
        public int Checktime { get; set; }

    }

    public partial class C2sAoiSkillCalinfo
    {
        public int SRid { get; set; }

        /// <summary>技能运行id</summary>
        public int Checktime { get; set; }

        /// <summary>时间</summary>
        public int? Timestamp { get; set; }

    }

    public partial class S2cAoiSkillAct
    {
        /// <summary>技能广播</summary>
        public int SkillId { get; set; }

        public string AttId { get; set; }

        public int Postype { get; set; }

        /// <summary>施法者的坐标类型:1是格子坐标,2是真是坐标</summary>
        public float X { get; set; }

        /// <summary>施法者的坐标</summary>
        public float Y { get; set; }

        public float Z { get; set; }

        public string TarId { get; set; }

        public int? Tx { get; set; }

        /// <summary>如果是aoe,有时候是没有目标点释放的,就需要有个释放点</summary>
        public int? Ty { get; set; }

        /// <summary>如果是aoe,有时候是没有目标点释放的,就需要有个释放点</summary>
        public global::Example.AoiSkillCalinfo Cal { get; set; }

        public int? Timestamp { get; set; }

        public int? Htype { get; set; }

    }

    public partial class C2sAoiSkillHit
    {
        /// <summary>击中</summary>
        public int SkillId { get; set; }

        public string TarId { get; set; }

        /// <summary>注意:主目标跟分目标计算公式不一样,所以如果有主目标的一定要把id发过来</summary>
        public int? Tx { get; set; }

        /// <summary>如果是aoe,有时候是没有目标点释放的,就需要有个释放点</summary>
        public int? Ty { get; set; }

        /// <summary>如果是aoe,有时候是没有目标点释放的,就需要有个释放点</summary>
        public string Axyz { get; set; }

        /// <summary>直接转发</summary>
        public int Sx { get; set; }

        /// <summary>施法者坐标</summary>
        public int Sz { get; set; }

        public int? Timestamp { get; set; }

    }

    public partial class AoiSkillChar
    {
        public string TarId { get; set; }

        public int Hp { get; set; }

        /// <summary>显示血量的,(加buff和非攻击技能加减血这里会是0,具体显示血量是在S2c_aoi_hp,因为童话那边如果不这样做,非技能就没目标)</summary>
        public int Nhp { get; set; }

        /// <summary>当前血量</summary>
        public int Hpmax { get; set; }

        /// <summary>最大血量</summary>
        public int Type { get; set; }

        /// <summary>hp扣血加血方式   	0:普通伤害(加血),1:暴击伤害,2:破格伤害,3:暴击破格伤害,4:miss,5:无敌,6.非攻击技能加减血,7:加buff</summary>
        public int Isdie { get; set; }

        /// <summary>1是,0否</summary>
        public float? X { get; set; }

        /// <summary>击退的坐标移动(真实的客户端坐标)</summary>
        public float? Y { get; set; }

        public float? Z { get; set; }

        public int? Shpstamp { get; set; }

    }

    public partial class S2cAoiSkillHit
    {
        public int SkillId { get; set; }

        public string AttId { get; set; }

        /// <summary>施法者</summary>
        public int Postype { get; set; }

        /// <summary>施法者的坐标类型:1是格子坐标,2是真是坐标</summary>
        public float X { get; set; }

        /// <summary>施法者的坐标</summary>
        public float Y { get; set; }

        public float Z { get; set; }

        public int? Tx { get; set; }

        /// <summary>受击位置</summary>
        public int? Ty { get; set; }

        public string Axyz { get; set; }

        public List<global::Example.AoiSkillChar> TarChars { get; set; }

        /// <summary>击中的目标</summary>
        public int? Timestamp { get; set; }

        public int Isbegin { get; set; }

        /// <summary>1是,0否			是否是直接出技能,只有npc才用此字段,npc瞬发不发S2c_aoi_skill_act</summary>
        public int? Htype { get; set; }

    }

    public partial class S2cAoiClientAddnpc
    {
        public string Extend { get; set; }

    }

    public partial class S2cAoiSp
    {
        public int Sp { get; set; }

    }

    public partial class S2cAoiSkillCtime
    {
        /// <summary>技能冷却时间</summary>
        public string Id { get; set; }

        /// <summary>技能的拥有者id</summary>
        public int SkillId { get; set; }

        public int Ctime { get; set; }

    }

    public partial class S2cAoiUiHp
    {
        public string Id { get; set; }

        public int Hp { get; set; }

        public int HpMax { get; set; }

    }

    public partial class S2cAoiUiBuff
    {
        public string Id { get; set; }

        public int BuffId { get; set; }

        public int Type { get; set; }

    }

    public partial class AoiUiSkill
    {
        public int SkillId { get; set; }

        public int SkillType { get; set; }

        /// <summary>1:普通攻击,2:技能攻击,3:合体技</summary>
        public int SkillLv { get; set; }

    }

    public partial class S2cAoiOwnUiinfo
    {
        public string Id { get; set; }

        /// <summary>技能的拥有者</summary>
        public List<global::Example.AoiUiSkill> Uiskill { get; set; }

        public int? Artimid { get; set; }

    }

    public partial class S2cAoiSkillAdd
    {
        public string Id { get; set; }

        public List<global::Example.AoiUiSkill> Uiskill { get; set; }

    }

    public partial class S2cAoiPassskillChange
    {
        public string Id { get; set; }

        public int? Omid { get; set; }

        /// <summary>被替换的技能编号</summary>
        public int Nmid { get; set; }

        public int Isset { get; set; }

    }

    public partial class AoiStipsCircle
    {
        public int X { get; set; }

        /// <summary>圆点x</summary>
        public int Y { get; set; }

        /// <summary>圆点y</summary>
        public int R { get; set; }

    }

    public partial class AoiStipsLine
    {
        public int Ax { get; set; }

        /// <summary>攻击者x   注意:90度的方向为攻击者对目标点</summary>
        public int Ay { get; set; }

        /// <summary>攻击者y</summary>
        public int Tx { get; set; }

        /// <summary>目标点x</summary>
        public int Ty { get; set; }

        /// <summary>目标点x</summary>
        public int Atype { get; set; }

        /// <summary>1为以攻击者为点延伸,2为以目为点延伸</summary>
        public int Len { get; set; }

        /// <summary>线长</summary>
        public float Accu { get; set; }

        /// <summary>精确宽,客户端的先宽则为accu * 2(左右两边)</summary>
        public List<int> Degree { get; set; }

    }

    public partial class AoiStipsSector
    {
        public int Ax { get; set; }

        /// <summary>攻击者x   注意:90度的方向为攻击者对目标点</summary>
        public int Ay { get; set; }

        /// <summary>攻击者y</summary>
        public int Tx { get; set; }

        /// <summary>目标点x</summary>
        public int Ty { get; set; }

        /// <summary>目标点x</summary>
        public int Atype { get; set; }

        /// <summary>1为以攻击者为点延伸,2为以目为点延伸</summary>
        public int Len { get; set; }

    }

    public partial class S2cAoiSkillTips
    {
        /// <summary>添加技能提示</summary>
        public int TipsId { get; set; }

        public List<global::Example.AoiStipsCircle> Circle { get; set; }

        public List<global::Example.AoiStipsLine> Line { get; set; }

        public List<global::Example.AoiStipsSector> Sector { get; set; }

    }

    public partial class S2cAoiSkillDeltips
    {
        /// <summary>删除技能提示</summary>
        public int TipsId { get; set; }

    }

    public partial class S2cAoiTeamHp
    {
        public string Id { get; set; }

        public int Hp { get; set; }

        public int HpMax { get; set; }

    }

    public partial class S2cAoiTeaminfo
    {
        /// <summary>组队的队员信息</summary>
        public string Id { get; set; }

        public string Name { get; set; }

        public int Grade { get; set; }

        public int Pos { get; set; }

        /// <summary>在队伍里面的排位</summary>
        public int Hp { get; set; }

        public int Hpmax { get; set; }

        public int IsLeader { get; set; }

        /// <summary>1是队长,0否</summary>
        public int Shape { get; set; }

    }

    public partial class S2cAoiTeamCleader
    {
        /// <summary>修改队长</summary>
        public string Leaderid { get; set; }

    }

    public partial class S2cAoiTeamOffline
    {
        public string Id { get; set; }

    }

    public partial class S2cAoiTeamLeave
    {
        public string Id { get; set; }

    }

    public partial class C2sAoiMove
    {
        public List<int> Pos { get; set; }

        /// <summary> x z</summary>
        public float Y { get; set; }

        public int Dir360 { get; set; }

        /// <summary>玩家移动到pos时的方向 0-360度</summary>
        public float? Speed { get; set; }

        public int? Type { get; set; }

    }

    public partial class C2sAoiPlayerFly
    {
        /// <summary>跳跃信息同步c2s</summary>
        public List<int> Pos { get; set; }

        /// <summary> x z</summary>
        public float Y { get; set; }

        public int Type { get; set; }

        /// <summary> 状态,2为1段跳，3为2段跳</summary>
        public float Time { get; set; }

        /// <summary> 跳跃最大时间</summary>
        public int Dir360 { get; set; }

        public float? VertSpeed { get; set; }

        /// <summary> 水平方向速度</summary>
        public float? HorizSpeed { get; set; }

        /// <summary> 垂直方向初始速度</summary>
        public float? HorizAccSpeed { get; set; }

        /// <summary> 水平反方向初始加速度</summary>
        public float? HorizEndSpeed { get; set; }

        /// <summary> 落下时水平速度</summary>
        public List<float> Syncpos { get; set; }

        /// <summary> 同步位置</summary>
        public float Timer { get; set; }

    }

    public partial class C2sAoiPlayerFlyFinished
    {
        public List<int> Pos { get; set; }

        /// <summary> x z</summary>
        public List<float> Syncpos { get; set; }

        public float Timer { get; set; }

    }

    public partial class S2cAoiPlayerFly
    {
        /// <summary>跳跃信息同步s2c</summary>
        public List<int> Pos { get; set; }

        /// <summary> x z</summary>
        public float Y { get; set; }

        public string Id { get; set; }

        public int Type { get; set; }

        /// <summary> 状态,2为1段跳，3为2段跳，4为位移同步</summary>
        public int Dir360 { get; set; }

        public float? VertSpeed { get; set; }

        /// <summary> 水平方向速度</summary>
        public float? HorizSpeed { get; set; }

        /// <summary> 垂直方向初始速度</summary>
        public float? HorizAccSpeed { get; set; }

        /// <summary> 水平反方向初始加速度</summary>
        public float? HorizEndSpeed { get; set; }

        /// <summary> 落下时水平速度</summary>
        public List<float> Syncpos { get; set; }

        /// <summary> 同步位置</summary>
        public float Timer { get; set; }

    }

    public partial class S2cAoiPlayerFlyFinished
    {
        public string Id { get; set; }

        public List<int> Pos { get; set; }

        /// <summary> x z</summary>
        public List<float> Syncpos { get; set; }

        public float Timer { get; set; }

    }

    public partial class S2cAoiPlayerFlyError
    {
        public List<int> Pos { get; set; }

        /// <summary> x z</summary>
        public float Y { get; set; }

    }

    public partial class C2sAoiPlotJump
    {
        /// <summary>剧情跳</summary>
        public int NowMapid { get; set; }

        public int NowMapno { get; set; }

        public int ToMapno { get; set; }

        public int Doorno { get; set; }

        public int Type { get; set; }

        /// <summary>1开始,2结束</summary>
        public List<int> Pos { get; set; }

        /// <summary>x z(格子坐标)</summary>
        public List<float> Syncpos { get; set; }

    }

    public partial class S2cAoiPlotJump
    {
        public string Rid { get; set; }

        public int NowMapid { get; set; }

        public int NowMapno { get; set; }

        public int ToMapno { get; set; }

        public int Doorno { get; set; }

        public int Type { get; set; }

        /// <summary>1开始,2结束</summary>
        public List<int> Pos { get; set; }

        /// <summary>x z(格子坐标)</summary>
        public List<float> Syncpos { get; set; }

    }

    public partial class AoiBufftips
    {
        public int Photo { get; set; }

        /// <summary>图标</summary>
        public string Name { get; set; }

        /// <summary>名字</summary>
        public List<string> Key { get; set; }

        public List<int> Value { get; set; }

        public List<string> Svalue { get; set; }

    }

    public partial class C2sAoiBufftips
    {
        public string Rid { get; set; }

    }

    public partial class S2cAoiBufftips
    {
        public string Rid { get; set; }

        public List<global::Example.AoiBufftips> Tips { get; set; }

    }

    public partial class S2cAoiFlydodge
    {
        public int Flydodge { get; set; }

        public int Cooltime { get; set; }

        public int? Isserver { get; set; }

    }

    /// <summary>场景附近公共聊天</summary>
    public partial class S2cAoiChatPublic
    {
        public int Channel { get; set; }

        /// <summary>频道</summary>
        public int SendType { get; set; }

        /// <summary>发送类型 1大喇叭 2小喇叭 0普通发话</summary>
        public string ChatName { get; set; }

        /// <summary>说话者名字</summary>
        public string ChatMsg { get; set; }

        /// <summary>说话内容</summary>
        public int Sex { get; set; }

        /// <summary>性别1男2女</summary>
        public string Uid { get; set; }

        /// <summary>说话者uid</summary>
        public int ChatTime { get; set; }

        /// <summary>时间</summary>
        public int? Grade { get; set; }

        /// <summary>等级</summary>
        public int? Photo { get; set; }

        /// <summary>头像</summary>
        public string VoiceSn { get; set; }

        /// <summary>声音sn编号</summary>
        public int? VoiceTime { get; set; }

        /// <summary>声音时长</summary>
        public string ClubId { get; set; }

        /// <summary>公会id</summary>
        public int? TeamId { get; set; }

        /// <summary>队伍id</summary>
        public int? Vip { get; set; }

        public int HostId { get; set; }

    }

    public partial class C2sAoiSprint
    {
        /// <summary>冲刺</summary>
        public List<int> Pos { get; set; }

        /// <summary> 服务端记录当前x z(格子)</summary>
        public List<float> Fpos { get; set; }

        /// <summary> 转发给客户端的目标x z(非格子)</summary>
        public float Y { get; set; }

        public int Dir360 { get; set; }

        /// <summary>玩家移动到pos时的方向 0-360度</summary>
        public int Type { get; set; }

    }

    public partial class S2cAoiSprint
    {
        public string Rid { get; set; }

        public List<float> Fpos { get; set; }

        public float Y { get; set; }

    }

    public partial class S2cAoiChangemapType
    {
        /// <summary>跳转场景类型</summary>
        public int Type { get; set; }

    }

    public partial class C2sAoiSearchnpc
    {
        public int NpcNo { get; set; }

    }

    public partial class S2cAoiReliveAfter
    {
        public int PlaceHolder { get; set; }

    }

    /// <summary>野外boss///////////////////</summary>
    public partial class YewaibossBelongInfo
    {
        public string Id { get; set; }

        public int RemainTime { get; set; }

    }

    public partial class S2cYewaibossBelonglist
    {
        public List<global::Example.YewaibossBelongInfo> List { get; set; }

        public string BossId { get; set; }

    }

    public partial class C2sYewaibossBelonglist
    {
        public int PlaceHolder { get; set; }

    }

    public partial class YewaibossScoreInfo
    {
        public string Uid { get; set; }

        public string Name { get; set; }

        public int Hurt { get; set; }

        /// <summary>伤害百分比</summary>
        public int Score { get; set; }

    }

    public partial class S2cYewaibossScorelist
    {
        public List<global::Example.YewaibossScoreInfo> List { get; set; }

        public int CanScore { get; set; }

        /// <summary>剩余可获侠义点</summary>
        public int SelfHurt { get; set; }

        /// <summary>自身伤害比</summary>
        public int JoinScore { get; set; }

    }

    public partial class C2sYewaibossScorelist
    {
        public int PlaceHolder { get; set; }

    }

    /// <summary>变身buff删除///////////////</summary>
    public partial class C2sAoiShapeshiftDel
    {
        public int Buffid { get; set; }

    }

    public partial class S2cAoiSkillerror
    {
        public string Id { get; set; }

        /// <summary> 玩家 id</summary>
        public int IsExist { get; set; }

        /// <summary> 1存在, 0不存在</summary>
        public List<int> Pos { get; set; }

        /// <summary> x z</summary>
        public float Y { get; set; }

    }

    /// <summary>-----------------------------------c2s-----------------------------------</summary>
    public partial class C2sLoginPlayerAdd
    {
        /// <summary>新建角色</summary>
        public string Name { get; set; }

        /// <summary>角色名</summary>
        public int? Sex { get; set; }

        /// <summary>性别，可选备用</summary>
        public int HeadId { get; set; }

        /// <summary>头像编号</summary>
        public int? Partnerno { get; set; }

        /// <summary>选择初始随从编号</summary>
        public int? Profession { get; set; }

    }

    public partial class C2sLoginPlayername
    {
        public string Name { get; set; }

    }

    public partial class S2cLoginPlayername
    {
        public int Exist { get; set; }

    }

    public partial class C2sLoginPlayerEnter
    {
        /// <summary>角色登录</summary>
        public string Id { get; set; }

        /// <summary>id：玩家选择的一个id登陆到游戏中</summary>
        public List<string> SceneName { get; set; }

        /// <summary>可以登录的场景</summary>
        public int Isall { get; set; }

    }

    public partial class C2sLoginPlayerRecon
    {
        /// <summary>角色重连</summary>
        public string Id { get; set; }

        /// <summary>id：玩家选择的一个id登陆到游戏中</summary>
        public int Time { get; set; }

        /// <summary>客户端连接时间</summary>
        public List<string> SceneName { get; set; }

        /// <summary>可以登录的场景</summary>
        public int Isall { get; set; }

        /// <summary>是否所有场景都有了		1是</summary>
        public string Sign { get; set; }

    }

    public partial class S2cLoginPlayerRecon
    {
        /// <summary>角色重连</summary>
        public int PlaceHolder { get; set; }

    }

    public partial class C2sLoginDelPlayer
    {
        /// <summary>删除角色</summary>
        public string UserId { get; set; }

    }

    public partial class C2sLoginCheckTime
    {
        /// <summary>与服务器对时</summary>
        public int PlaceHolder { get; set; }

    }

    public partial class S2cLoginCheckTime
    {
        public string Sec { get; set; }

        /// <summary>10位秒</summary>
        public uint Usec { get; set; }

    }

    /// <summary>联运平台账号登录</summary>
    public partial class C2sLoginCorpAccount
    {
        public int CorpId { get; set; }

        /// <summary>联运商编号</summary>
        public string Acct { get; set; }

        /// <summary>联运商玩家账号</summary>
        public int Adult { get; set; }

        /// <summary>账号防沉迷信息,0,1,2</summary>
        public int LoginTime { get; set; }

        /// <summary>账号在平台的登录时间，登录时间超过10分钟，则票据过期</summary>
        public string Sign { get; set; }

        /// <summary>验证票据信息,md5({corp_id}_{acct_id}_{login_time}_{平台密匙})</summary>
        public string Extdata { get; set; }

    }

    /// <summary>-----------------------------------s2c-----------------------------------</summary>
    public partial class S2cLoginError
    {
        /// <summary>返回登录错误信息</summary>
        public int ErrNo { get; set; }

        /// <summary>错误编号</summary>
        public string ErrDesc { get; set; }

    }

    public partial class S2cLoginKickout
    {
        public int PlaceHolder { get; set; }

    }

    public partial class LoginListInfo
    {
        /// <summary>登录角色信息</summary>
        public string Name { get; set; }

        /// <summary>角色名</summary>
        public int HeadId { get; set; }

        /// <summary>头像ID</summary>
        public string Id { get; set; }

        /// <summary>角色ID</summary>
        public int Grade { get; set; }

        /// <summary>等级</summary>
        public int Family { get; set; }

        /// <summary>门派ID</summary>
        public int CreateTime { get; set; }

        /// <summary>创建时间</summary>
        public int? Sex { get; set; }

        /// <summary>性别</summary>
        public int? Profession { get; set; }

    }

    public partial class S2cLoginPlayerList
    {
        /// <summary>发送角色列表</summary>
        public List<global::Example.LoginListInfo> ListInfo { get; set; }

    }

    public partial class S2cLoginStatus
    {
        /// <summary>发送登录状态</summary>
        public int Status { get; set; }

    }

    public partial class S2cLoginTips
    {
        /// <summary>登录提示</summary>
        public string Msg { get; set; }

    }

    public partial class C2sLoginJihuo
    {
        public string Jihuoma { get; set; }

    }

    public partial class S2cLoginJihuo
    {
        public int Placeholder { get; set; }

    }

    public partial class S2cLoginAddplayer
    {
        public string Uid { get; set; }

        public string Name { get; set; }

        public int Yuanbao { get; set; }

        public int Vip { get; set; }

        public int CreateTime { get; set; }

    }

    public partial class C2sLoginNewok
    {
        /// <summary>loading完毕进入游戏</summary>
        public int Placeholder { get; set; }

    }

}
