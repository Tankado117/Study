public class Card
{
	//�J�[�h�̐����A�X�[�g���i�[
	private int number;
	private int suit;

	//�J�[�h�����̂��߂̕ϐ�
	public static int JOKER = 0;
	public static int SUIT_CLUB = 1;
	public static int SUIT_DIAMOND = 2;
	public static int SUIT_HEART = 3;
	public static int SUIT_SPADE = 4;
	
	//����������
	public int showNumber(){
		return this.number;	
	}
}