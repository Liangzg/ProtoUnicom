
namespace Riverlake.Network {
    public sealed class Protocal {
        ///BUILD TABLE
        public const int Connect = 101;         //���ӷ�����
        public const int Exception = 102;       //�쳣����
        public const int Disconnect = 103;      //��������
        public const int Message = 104;         //������Ϣ
        public const int Reconnected = 105;     //����������
        public const int BeginReconnect = 106;  //����������ʧ��
        public const int KickOut = 107;         //���߳�������
        public const int PingUpdate = 108;         //pingֵ
        public const int AccountConflict = 109; //������
        public const int HeartBeat2Server = 110; //����������������
        public const int WeakMessage = 111;     //aoi�Ȳ���Ҫ��Э�����⴦��
    }
}