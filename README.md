# DebugStation �A�v���P�[�V����

�f�o�b�O�x���pWindows�A�v���P�[�V�����ł��BNovLab.Base �N���X���C�u�����ƕ��p���܂��B


## ����

- Debug �N���X�ɂ��f�o�b�O�o�͂�ATrace �N���X�ɂ��g���[�X�o�͂��A�f�o�b�O�Ώۃv���O��������󂯎���ĕ\�����邱�Ƃ��ł��܂��B
- �A�g���ē��삷�镡���v���Z�X����̏o�͓��e���ЂƂ܂Ƃ߂ɘ��Ղ��邱�Ƃ��ł��܂��B
- NLDebug �N���X��ʂ����f�o�b�O�x���@�\�𗘗p���邱�Ƃ��ł��܂��B


## �����

- Windows 8.1�ȍ~
- .NET Framework 4.0 �ȍ~�A�܂��͌݊����̂��� .NET ����

### �f�o�b�O�Ώۃv���O�������̕K�v�v��

- NovLab.Base �N���X���C�u����


## �ˑ����|�W�g��

- NovLab.Base �N���X���C�u����
- NovLab.Windows.Forms �N���X���C�u����

### ���[�J�����|�W�g���ɂ�����t�H���_�[�z�u�ɂ���

�{���|�W�g���̃\�����[�V�����ƁA�ˑ����|�W�g���̃\�����[�V�����́A�ȉ��̂悤�ɓ����e�t�H���_�[�̉��֔z�u���Ă��������B
```
���e�t�H���_�[��
  �� DebugStation �\�����[�V����
  �� NovLab.Base �\�����[�V����
  �� NovLab.Windows.Forms �\�����[�V����
```


## �g����

- �f�o�b�O�Ώۃv���O�������ňȉ��̑Ή����s���܂��B
  1. NovLab.Base �A�Z���u���ւ̎Q�Ƃ�ǉ����܂��B
  2. DebugStationTraceListener ���g���[�X���X�i�[�ɒǉ����܂��B
     �v���O�����̏��������ȂǂɈȉ��̍s��ǉ����邩�A�A�v���P�[�V�����\���t�@�C�����C�����܂��B
      ```
      using NovLab.DebugStation;

      Debug.Listeners.Add(new DebugStationTraceListener());
      ```

- ��L�Ή����s�����̂��ADebugStation �A�v���P�[�V�������N��������ԂŃf�o�b�O�Ώۃv���O���������s����ƁA�f�o�b�O�o�͂�g���[�X�o�͂� DebugStation �ɕ\������܂��B

- NLDebug �N���X���g���ƁADebugStation �Ǝ��̃f�o�b�O�x���@�\�𗘗p���邱�Ƃ��ł��܂��B


## �֘A���|�W�g��

- **TestDebugStation**�F�{�A�v���P�[�V�����̃e�X�g�p�v���W�F�N�g�ł��B


## �J����

### �J���c�[���ASDK�Ȃ�
- Visual Studio Community 2019
  - ���[�N���[�h�F.NET �f�X�N�g�b�v�J��

### ����
- C#
