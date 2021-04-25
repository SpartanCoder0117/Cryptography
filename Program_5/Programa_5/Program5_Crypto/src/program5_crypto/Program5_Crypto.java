/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package program5_crypto;
import javax.crypto.Cipher;
import javax.crypto.spec.SecretKeySpec;
import javax.swing.JFileChooser;
import java.awt.image.BufferedImage;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.security.Key;
import java.security.spec.AlgorithmParameterSpec;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.crypto.spec.IvParameterSpec;
import javax.imageio.ImageIO;
import Atxy2k.CustomTextField.RestrictedTextField;
/**
 *
 * @author jmaci
 */
public class Program5_Crypto extends javax.swing.JFrame {

    /**
     * Creates new form Program5_Crypto
     */
    String name;
    String path;
    File files;
    File files2;
    int HEADER_LENGTH = 14;  // 14 byte bmp header
    int INFO_HEADER_LENGTH = 40; // 40-byte bmp info header
    
    private static String key = "";
    private static String key2 = "";
    private static String iv = "";
    private static String initVector = "";
    private static final int headerSize = 54;
    
    public Program5_Crypto() {
        initComponents();
        RestrictedTextField restricted = new RestrictedTextField(jTextField1);
        restricted.setLimit(16);
        RestrictedTextField restricted2 = new RestrictedTextField(jTextField2);
        restricted2.setLimit(8);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();
        jTextField1 = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jCheckBox1 = new javax.swing.JCheckBox();
        jButton4 = new javax.swing.JButton();
        jLabel3 = new javax.swing.JLabel();
        jTextField2 = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jTextField3 = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jComboBox1 = new javax.swing.JComboBox<>();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jButton1.setText("Select File");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jButton2.setText("Encrypt");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jButton3.setText("Decrypt");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });

        jLabel1.setText("Key AES");

        jCheckBox1.setText("AES/DES");

        jButton4.setText("Save Image");
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });

        jLabel3.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        jLabel3.setText("AES/DES Image Cipher Program");

        jLabel2.setText("Key DES");

        jLabel4.setText("IV");

        jComboBox1.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "ECB", "CBC", "OFB", "CFB" }));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap(52, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(7, 7, 7)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel1)
                                    .addComponent(jLabel2)
                                    .addComponent(jLabel4, javax.swing.GroupLayout.Alignment.TRAILING))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jTextField3)
                                    .addComponent(jTextField2)
                                    .addComponent(jTextField1)))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(32, 32, 32)
                                        .addComponent(jButton2)
                                        .addGap(43, 43, 43)
                                        .addComponent(jButton3))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(jButton1)
                                            .addComponent(jCheckBox1))
                                        .addGap(77, 77, 77)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                            .addComponent(jButton4)
                                            .addComponent(jComboBox1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                                .addGap(0, 0, Short.MAX_VALUE)))
                        .addGap(47, 47, 47))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addGap(37, 37, 37))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(28, 28, 28)
                .addComponent(jLabel3)
                .addGap(50, 50, 50)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton1)
                    .addComponent(jButton4))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jComboBox1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jCheckBox1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jTextField1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jTextField2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jTextField3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton2)
                    .addComponent(jButton3))
                .addContainerGap(19, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
   
    public void writeToFile(byte[] header, byte [] infoheader, byte [] content, String fileToWrite) throws Exception{
        FileOutputStream fos = new FileOutputStream(fileToWrite);
        fos.write(header);
        fos.write(infoheader);
        fos.write(content);
        fos.flush();
        fos.close();    
    }
    
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        JFileChooser jf= new JFileChooser();           
            int r= jf.showOpenDialog(null);
            if(r==JFileChooser.APPROVE_OPTION){
                files2 = jf.getSelectedFile();
                name = files2.getAbsolutePath();
                System.out.println(name);
                //Imagen_frame1();
            }
    }//GEN-LAST:event_jButton1ActionPerformed

    private void AES_EN_ECB()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            FileInputStream fs = new FileInputStream(name);

            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);

            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);

            byte[] content = new byte[fs.available()];
            fs.read(content);

            Cipher cipher = Cipher.getInstance("AES/ECB/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            cipher.init(Cipher.ENCRYPT_MODE, secretKey);
            byte[] imageModified = cipher.doFinal(content);

            writeToFile(header, infoheader, imageModified, path + "\\AES_ECB_EN.bmp");
            
        }catch(Exception ex)
        {
            ex.printStackTrace();
        }
                    
    }
    
    private void AES_DE_ECB()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        try
        {
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("AES/ECB/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            cipher.init(Cipher.DECRYPT_MODE, secretKey);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\AES_ECB_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }
    }
    
    private void AES_EN_CBC()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        try
        {
            FileInputStream fs = new FileInputStream(name);

            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);

            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);

            byte[] content = new byte[fs.available()];
            fs.read(content);

            Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.ENCRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);

            writeToFile(header, infoheader, imageModified, path + "\\AES_CBC_EN.bmp");
        }catch(Exception e)
        {
            e.printStackTrace();
        }
        
    }
    
    private void AES_DEC_CBC()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        try
        {
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.DECRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\AES_CBC_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }
    }
    
    private void AES_EN_OFB()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            FileInputStream fs = new FileInputStream(name);

            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);

            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);

            byte[] content = new byte[fs.available()];
            fs.read(content);

            Cipher cipher = Cipher.getInstance("AES/OFB/NoPadding");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.ENCRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);

            writeToFile(header, infoheader, imageModified, path + "\\AES_OFB_EN.bmp");
        }catch(Exception e)
        {
            e.printStackTrace();
        }
    }
    
    private void AES_DEC_OFB()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("AES/OFB/NoPadding");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.DECRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\AES_OFB_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }
    }
    
    private void AES_EN_CFB()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            FileInputStream fs = new FileInputStream(name);

            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);

            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);

            byte[] content = new byte[fs.available()];
            fs.read(content);

            Cipher cipher = Cipher.getInstance("AES/CFB/NoPadding");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.ENCRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);

            writeToFile(header, infoheader, imageModified, path + "\\AES_CFB_EN.bmp");
        }catch(Exception e)
        {
            e.printStackTrace();
        }
    }
    
    private void AES_DEC_CFB()
    {
        key = jTextField1.getText();
        //key2 = jTextField2.getText();
        iv = jTextField3.getText();
        try
        {
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("AES/CFB/NoPadding");
            Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.DECRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\AES_CFB_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }
    }
    
    private void DES_EN_ECB()
    {
        //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/ECB/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            cipher.init(Cipher.ENCRYPT_MODE, secretKey);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_ECB_EN.bmp");            
        }catch(Exception e)
        {
            e.printStackTrace();
        }
        
    }
    
    private void DES_DEC_ECB()
    {
        //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/ECB/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            cipher.init(Cipher.DECRYPT_MODE, secretKey);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_ECB_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }
    }
    
    private void DES_EN_CBC()
    {
        //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/CBC/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.ENCRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_CBC_EN.bmp");            
        }catch(Exception e)
        {
            e.printStackTrace();
        }        
    }
    
    private void DES_DEC_CBC()
    {
        //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/CBC/PKCS5PADDING");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.DECRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_CBC_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }        
    }
    
    private void DES_EN_OFB()
    {
       //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/OFB/NoPadding");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.ENCRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_OFB_EN.bmp");            
        }catch(Exception e)
        {
            e.printStackTrace();
        } 
    }
    
    private void DES_DEC_OFB()
    {
       //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/OFB/NoPadding");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.DECRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_OFB_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }         
    }
    
    private void DES_EN_CFB()
    {
       //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/CFB/NoPadding");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.ENCRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_CFB_EN.bmp");            
        }catch(Exception e)
        {
            e.printStackTrace();
        } 
    }
    
    private void DES_DEC_CFB()
    {
      //key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();
        
        try
        {
            //restricted.setLimit(8);
            //File f = new File(name);
            FileInputStream fs = new FileInputStream(name);
        
            byte header [] = new byte[HEADER_LENGTH];
            fs.read(header, 0, HEADER_LENGTH);
        
            byte infoheader [] = new byte[INFO_HEADER_LENGTH];
            fs.read(infoheader, 0, INFO_HEADER_LENGTH);
        
            byte[] content = new byte[fs.available()];
            fs.read(content);
        
            Cipher cipher = Cipher.getInstance("DES/CFB/NoPadding");
            Key secretKey = new SecretKeySpec(key2.getBytes(), "DES");
            IvParameterSpec IV = new IvParameterSpec(iv.getBytes("UTF-8"));
            cipher.init(Cipher.DECRYPT_MODE, secretKey, IV);
            byte[] imageModified = cipher.doFinal(content);
        
            writeToFile(header, infoheader, imageModified, path + "\\DES_CFB_DE.bmp");
            
        }catch(Exception e)
        {
            e.printStackTrace();
        }  
    }
    
    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // TODO add your handling code here:
        /*key = jTextField1.getText();
        key2 = jTextField2.getText();
        iv = jTextField3.getText();*/
        //RestrictedTextField restricted = new RestrictedTextField(jTextField1);
        if(jCheckBox1.isSelected())
        {
            //AES ENCRYPT            
            try 
            {
                if(jComboBox1.getSelectedIndex() == 0)
                {
                    System.out.println("Select ECB");
                    AES_EN_ECB();
                }else if(jComboBox1.getSelectedIndex() == 1)
                {
                    System.out.println("Select CBC");
                    AES_EN_CBC();
                }else if(jComboBox1.getSelectedIndex() == 2)
                {
                    System.out.println("Select OFB");
                    AES_EN_OFB();
                }else if(jComboBox1.getSelectedIndex() == 3)
                {
                    System.out.println("Select CFB");
                    AES_EN_CFB();
                }
            
            } catch (Exception ex) 
            {
                ex.printStackTrace();
            }
        }else
        {
            //DES ENCRYPT
            try
            {
                if(jComboBox1.getSelectedIndex() == 0)
                {
                    System.out.println("Select ECB");
                    DES_EN_ECB();
                }else if(jComboBox1.getSelectedIndex() == 1)
                {
                    System.out.println("Select CBC");
                    DES_EN_CBC();                    
                }else if(jComboBox1.getSelectedIndex() == 2)
                {
                    DES_EN_OFB();
                }else if(jComboBox1.getSelectedIndex() == 3)
                {
                    DES_EN_CFB();
                }
            } catch (Exception e) 
            {
                e.printStackTrace();
            }
        }
        
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        // TODO add your handling code here:
        key = jTextField1.getText();        
        key2 = jTextField2.getText();
        if(jCheckBox1.isSelected())
        {
            //AES DECRYPT
            try 
            {
                if(jComboBox1.getSelectedIndex() == 0)
                {
                    System.out.println("Select ECB_D");
                    AES_DE_ECB();
                }else if(jComboBox1.getSelectedIndex() == 1)
                {
                    System.out.println("Select CBC_D");
                    AES_DEC_CBC();
                }else if(jComboBox1.getSelectedIndex() == 2)
                {
                    System.out.println("Select OFB_D");
                    AES_DEC_OFB();
                }else if(jComboBox1.getSelectedIndex() == 3)
                {
                    System.out.println("Select CFB_D");
                    AES_DEC_CFB();
                }
            
            } catch (Exception e)
            {
                e.printStackTrace();
            }
        }else
        {
            //DES DECRYPT
            try 
            {              
                if(jComboBox1.getSelectedIndex() == 0)
                {
                    System.out.println("Select ECB_D");
                    DES_DEC_ECB();
                }else if(jComboBox1.getSelectedIndex() == 1)
                {
                    System.out.println("Select CBC_D");
                    DES_DEC_CBC();
                }else if(jComboBox1.getSelectedIndex() == 2)
                {
                    DES_DEC_OFB();
                }else if(jComboBox1.getSelectedIndex() == 3)
                {
                    DES_DEC_CFB();
                }
         
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }//GEN-LAST:event_jButton3ActionPerformed

    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
        // TODO add your handling code here:
        JFileChooser jf= new JFileChooser();  
        jf.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
        int r= jf.showOpenDialog(null);
        if(r==JFileChooser.APPROVE_OPTION){
            files = jf.getSelectedFile();
            path = files.getAbsolutePath();
            System.out.println(path);
        }
    }//GEN-LAST:event_jButton4ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Program5_Crypto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Program5_Crypto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Program5_Crypto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Program5_Crypto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Program5_Crypto().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JButton jButton4;
    private javax.swing.JCheckBox jCheckBox1;
    private javax.swing.JComboBox<String> jComboBox1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JTextField jTextField2;
    private javax.swing.JTextField jTextField3;
    // End of variables declaration//GEN-END:variables
}