/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package Ventanas;

import Clases.Registro;


import java.awt.event.KeyEvent;

import java.util.ArrayList;
import java.util.Iterator;
import javax.swing.JOptionPane;

import javax.swing.RowFilter;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableRowSorter;

public class MenuPrincipal extends javax.swing.JFrame {
int elementoBuscar;
    public ArrayList<Registro> resultados;
int contador=1;

String filtro;
    public MenuPrincipal() {
        initComponents();
        
        IniciarTabla();
        IniciarTabla1();
        String numero=String.valueOf(contador);
        txtIdPartido.setText(numero);
        
        
        resultados = new ArrayList<>();
    }

    public ArrayList<Registro> getResultados() {
        return resultados;
    }


    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTabbedPane1 = new javax.swing.JTabbedPane();
        jPanel4 = new javax.swing.JPanel();
        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        jPInputBox = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txtIdJornada = new javax.swing.JTextField();
        jPInputBox1 = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        txtIdPartido = new javax.swing.JTextField();
        jPInputBox2 = new javax.swing.JPanel();
        jLabel4 = new javax.swing.JLabel();
        jDFechaPartido = new com.toedter.calendar.JDateChooser();
        jPInputBox3 = new javax.swing.JPanel();
        jLabel5 = new javax.swing.JLabel();
        txtNombreEquipoA = new javax.swing.JTextField();
        jPInputBox4 = new javax.swing.JPanel();
        jLabel6 = new javax.swing.JLabel();
        txtCarrerasEquipoA = new javax.swing.JTextField();
        jPInputBox5 = new javax.swing.JPanel();
        jLabel7 = new javax.swing.JLabel();
        txtNombreEquipoB = new javax.swing.JTextField();
        jPInputBox6 = new javax.swing.JPanel();
        jLabel8 = new javax.swing.JLabel();
        txtCarrerasEquipoB = new javax.swing.JTextField();
        jPInputBox7 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        ckbExtra = new javax.swing.JCheckBox();
        jPanel3 = new javax.swing.JPanel();
        btnNuevo = new javax.swing.JButton();
        jPanel5 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTLista = new javax.swing.JTable();
        jPanel6 = new javax.swing.JPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTBusca = new javax.swing.JTable();
        txtBuscar = new javax.swing.JTextField();
        btnBuscar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle(" Grandes Ligas de Béisbol");

        jPanel1.setPreferredSize(new java.awt.Dimension(0, 50));
        jPanel1.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 0, 5));

        jLabel1.setFont(new java.awt.Font("Segoe UI", 0, 24)); // NOI18N
        jLabel1.setText("Agregar registro");
        jPanel1.add(jLabel1);

        jPanel2.setLayout(new javax.swing.BoxLayout(jPanel2, javax.swing.BoxLayout.Y_AXIS));

        jPInputBox.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel2.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel2.setText("ID de la jornada:");
        jLabel2.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox.add(jLabel2);

        txtIdJornada.setPreferredSize(new java.awt.Dimension(300, 35));
        txtIdJornada.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtIdJornadaKeyTyped(evt);
            }
        });
        jPInputBox.add(txtIdJornada);

        jPanel2.add(jPInputBox);

        jPInputBox1.setPreferredSize(new java.awt.Dimension(360, 2));
        jPInputBox1.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel3.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel3.setText("ID del Partido:");
        jLabel3.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox1.add(jLabel3);

        txtIdPartido.setEditable(false);
        txtIdPartido.setPreferredSize(new java.awt.Dimension(300, 35));
        jPInputBox1.add(txtIdPartido);

        jPanel2.add(jPInputBox1);

        jPInputBox2.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox2.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel4.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel4.setText("Fecha del partido:");
        jLabel4.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox2.add(jLabel4);

        jDFechaPartido.setPreferredSize(new java.awt.Dimension(300, 35));
        jPInputBox2.add(jDFechaPartido);

        jPanel2.add(jPInputBox2);

        jPInputBox3.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox3.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel5.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel5.setText("Nombre del equipo A:");
        jLabel5.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox3.add(jLabel5);

        txtNombreEquipoA.setPreferredSize(new java.awt.Dimension(300, 35));
        txtNombreEquipoA.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtNombreEquipoAKeyTyped(evt);
            }
        });
        jPInputBox3.add(txtNombreEquipoA);

        jPanel2.add(jPInputBox3);

        jPInputBox4.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox4.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel6.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel6.setText("Carreras anotadas equipo A:");
        jLabel6.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox4.add(jLabel6);

        txtCarrerasEquipoA.setPreferredSize(new java.awt.Dimension(300, 35));
        txtCarrerasEquipoA.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtCarrerasEquipoAKeyTyped(evt);
            }
        });
        jPInputBox4.add(txtCarrerasEquipoA);

        jPanel2.add(jPInputBox4);

        jPInputBox5.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox5.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel7.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel7.setText("Nombre del equipo B:");
        jLabel7.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox5.add(jLabel7);

        txtNombreEquipoB.setPreferredSize(new java.awt.Dimension(300, 35));
        txtNombreEquipoB.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtNombreEquipoBKeyTyped(evt);
            }
        });
        jPInputBox5.add(txtNombreEquipoB);

        jPanel2.add(jPInputBox5);

        jPInputBox6.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox6.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel8.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel8.setText("Carreras anotadas equipo B:");
        jLabel8.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox6.add(jLabel8);

        txtCarrerasEquipoB.setPreferredSize(new java.awt.Dimension(300, 35));
        txtCarrerasEquipoB.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtCarrerasEquipoBKeyTyped(evt);
            }
        });
        jPInputBox6.add(txtCarrerasEquipoB);

        jPanel2.add(jPInputBox6);

        jPInputBox7.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox7.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel9.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel9.setText("Hubo extra-innings:");
        jLabel9.setPreferredSize(new java.awt.Dimension(173, 35));
        jPInputBox7.add(jLabel9);

        ckbExtra.setPreferredSize(new java.awt.Dimension(200, 20));
        jPInputBox7.add(ckbExtra);

        jPanel2.add(jPInputBox7);

        jPanel3.setPreferredSize(new java.awt.Dimension(30, 50));
        jPanel3.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 0, 5));

        btnNuevo.setText("Agregar");
        btnNuevo.setHorizontalTextPosition(javax.swing.SwingConstants.LEFT);
        btnNuevo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnNuevoActionPerformed(evt);
            }
        });
        jPanel3.add(btnNuevo);

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 824, Short.MAX_VALUE)
            .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel4Layout.createSequentialGroup()
                    .addGap(0, 0, Short.MAX_VALUE)
                    .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, 571, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, 571, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, 571, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGap(0, 0, Short.MAX_VALUE)))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 591, Short.MAX_VALUE)
            .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel4Layout.createSequentialGroup()
                    .addGap(0, 0, Short.MAX_VALUE)
                    .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGap(0, 0, 0)
                    .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, 354, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGap(0, 0, 0)
                    .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGap(0, 0, Short.MAX_VALUE)))
        );

        jTabbedPane1.addTab("Registro de resultados", jPanel4);

        jPanel5.setLayout(new java.awt.BorderLayout());

        jTLista.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jTLista.getTableHeader().setReorderingAllowed(false);
        jScrollPane1.setViewportView(jTLista);
        if (jTLista.getColumnModel().getColumnCount() > 0) {
            jTLista.getColumnModel().getColumn(0).setResizable(false);
            jTLista.getColumnModel().getColumn(1).setResizable(false);
            jTLista.getColumnModel().getColumn(2).setResizable(false);
            jTLista.getColumnModel().getColumn(3).setResizable(false);
        }

        jPanel5.add(jScrollPane1, java.awt.BorderLayout.CENTER);

        jTabbedPane1.addTab("Listado de resultados", jPanel5);

        jTBusca.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jTBusca.getTableHeader().setReorderingAllowed(false);
        jScrollPane2.setViewportView(jTBusca);

        txtBuscar.setPreferredSize(new java.awt.Dimension(300, 35));
        txtBuscar.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtBuscarKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtBuscarKeyTyped(evt);
            }
        });

        btnBuscar.setText("Guardar cambios");
        btnBuscar.setPreferredSize(new java.awt.Dimension(75, 35));
        btnBuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel6Layout = new javax.swing.GroupLayout(jPanel6);
        jPanel6.setLayout(jPanel6Layout);
        jPanel6Layout.setHorizontalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 824, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addGap(16, 16, 16)
                .addComponent(txtBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btnBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, 143, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        jPanel6Layout.setVerticalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addGap(19, 19, 19)
                .addGroup(jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 513, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        jTabbedPane1.addTab("Búsqueda de resultados y edición de resultados", jPanel6);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jTabbedPane1)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jTabbedPane1)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txtIdJornadaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtIdJornadaKeyTyped
        int caracter = evt.getKeyChar();
 if (txtIdJornada.getText().length() > 2) {
            getToolkit().beep();
            evt.consume();}
        if (((caracter < '0' || caracter > '9'))
                && (caracter != KeyEvent.VK_BACK_SPACE)) {
            getToolkit().beep();
            evt.consume();
        }

    }//GEN-LAST:event_txtIdJornadaKeyTyped

    private void txtNombreEquipoAKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNombreEquipoAKeyTyped
        if (txtNombreEquipoA.getText().length() > 19) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtNombreEquipoAKeyTyped

    private void txtCarrerasEquipoAKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtCarrerasEquipoAKeyTyped
        int caracter = evt.getKeyChar();

        if (((caracter < '0' || caracter > '9'))
                && (caracter != KeyEvent.VK_BACK_SPACE)) {
            getToolkit().beep();
            evt.consume();
        }
        if (txtCarrerasEquipoA.getText().length() > 1) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtCarrerasEquipoAKeyTyped

    private void txtNombreEquipoBKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNombreEquipoBKeyTyped
        if (txtNombreEquipoB.getText().length() > 19) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtNombreEquipoBKeyTyped

    private void txtCarrerasEquipoBKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtCarrerasEquipoBKeyTyped
        int caracter = evt.getKeyChar();

        if (((caracter < '0' || caracter > '9'))
                && (caracter != KeyEvent.VK_BACK_SPACE)) {
            getToolkit().beep();
            evt.consume();
        }
        if (txtCarrerasEquipoB.getText().length() > 1) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtCarrerasEquipoBKeyTyped

    private void btnNuevoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnNuevoActionPerformed
        if (txtIdJornada.getText().isEmpty() || txtNombreEquipoA.getText().isEmpty()|| txtNombreEquipoB.getText().isEmpty()|| txtCarrerasEquipoA.getText().isEmpty()||txtCarrerasEquipoB.getText().isEmpty() ) {
            JOptionPane.showMessageDialog(this, "No pueden quedar campos vacíos ");
        } else {contador++;
        String numero=String.valueOf(contador);
        txtIdPartido.setText(numero);     
  Registro nuevo = getRegistro();
        resultados.add(nuevo);
        CargarTabla();
        CargarTabla2();

        txtIdJornada.setText(null);
        txtNombreEquipoA.setText(null);
        txtNombreEquipoB.setText(null);
        txtCarrerasEquipoA.setText(null);
        txtCarrerasEquipoB.setText(null);
        jDFechaPartido.setDate(null);
        ckbExtra.setSelected(false);
        JOptionPane.showMessageDialog(this, "Partido Agregado");
        }



        
        
        
    }//GEN-LAST:event_btnNuevoActionPerformed

    private void btnBuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarActionPerformed
       Registro nuevo = getRegistro();
        resultados.add(nuevo);
        CargarTabla();
        

    }//GEN-LAST:event_btnBuscarActionPerformed

    private void txtBuscarKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtBuscarKeyTyped
       
    }//GEN-LAST:event_txtBuscarKeyTyped

    private void txtBuscarKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtBuscarKeyReleased
        DefaultTableModel table = (DefaultTableModel)jTBusca.getModel();
        String search = txtBuscar.getText();
        TableRowSorter<DefaultTableModel> tr = new TableRowSorter<DefaultTableModel>(table);
        jTBusca.setRowSorter(tr);
        tr.setRowFilter(RowFilter.regexFilter(search));
    }//GEN-LAST:event_txtBuscarKeyReleased

    public void CargarTabla() {
        Object[][] datos = new Object[resultados.size()][8];
        if (!resultados.isEmpty()) {

            Iterator i = resultados.iterator();
            int f = 0;
            while (i.hasNext()) {
                Registro r = (Registro) i.next();
                datos[f][0] = r.getIDJornada();
                datos[f][1] = r.getIDPartido();
                datos[f][2] = r.getFechaPartido();
                datos[f][3] = r.getNombreEquipoA();
                datos[f][4] = r.getCarrerasEquipoA();
                datos[f][5] = r.getNombreEquipoB();
                datos[f][6] = r.getCarrerasEquipoB();
                datos[f][7] = r.isExtraInnings() ? "Si" : "No";
                f++;
            }

        }
        Object[] columnas = {
            "ID Jornada", "ID Partido", "Fecha Partido", "Nombre Equipo A", "Carreras Equipo A", "Nombre Equipo B", "Carreras Equipo B", "Extra Innings"
        };

        DefaultTableModel modelo = new DefaultTableModel(datos, columnas){
@Override
        public boolean isCellEditable(int filas, int columna){
        return false;
    }
        };
        jTLista.setModel(modelo);
        

    }
    
    private void CargarTabla2() {
        Object[][] datos = new Object[resultados.size()][4];
        if (!resultados.isEmpty()) {
             
        Iterator i = resultados.iterator();
        int f = 0;
        while (i.hasNext()) {
            Registro r=(Registro) i.next();  
            datos[f][0] = r.getIDPartido();
            datos[f][1] = r.getCarrerasEquipoA();
            datos[f][2] = r.getCarrerasEquipoB();
            datos[f][3] = r.isExtraInnings() ? "Si" : "No";
            f++;
        }
      
        }
          Object[] columnas = {
           "ID Partido","Carreras Equipo A", "Carreras Equipo B", "Extra Innings"
        };
          
        DefaultTableModel modelo = new DefaultTableModel(datos, columnas);
        
jTBusca.setModel(modelo);
CargarTabla();
       
    }

    
    public Registro getRegistro() {
        setVisible(true);

        int IDJornada = Integer.parseInt(txtIdJornada.getText());
        int IDPartido = Integer.parseInt(txtIdPartido.getText());
        String fechaPartido = jDFechaPartido.getDate().toString();
        String nombreEquipoA = txtNombreEquipoA.getText();
        int carrerasEquipoA = Integer.parseInt(txtCarrerasEquipoA.getText());
        String nombreEquipoB = txtNombreEquipoB.getText();
        int carrerasEquipoB = Integer.parseInt(txtCarrerasEquipoB.getText());
        boolean extraInnings = ckbExtra.isSelected();
        return new Registro(IDJornada, IDPartido, fechaPartido, nombreEquipoA, carrerasEquipoA, nombreEquipoB, carrerasEquipoB, extraInnings);
    }
  public void IniciarTabla() {
        Object[][] datos = new Object[1][8];
       
        Object[] columnas = {
            "ID Jornada", "ID Partido", "Fecha Partido", "Nombre Equipo A", "Carreras Equipo A", "Nombre Equipo B", "Carreras Equipo B", "Extra Innings"
        };

        DefaultTableModel modelo = new DefaultTableModel(datos, columnas){
@Override
        public boolean isCellEditable(int filas, int columna){
        return false;
    }
        };
        jTLista.setModel(modelo);
        

    }
   public void IniciarTabla1() {
        Object[][] datos = new Object[1][8];
       
        Object[] columnas = {
            "Carreras Equipo A", "Carreras Equipo B", "Extra Innings"
        };

        DefaultTableModel modelo = new DefaultTableModel(datos, columnas){
@Override
        public boolean isCellEditable(int filas, int columna){
        return false;
    }
        };
        jTBusca.setModel(modelo);
        

    }


   

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new MenuPrincipal().setVisible(true);

            }

        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnNuevo;
    private javax.swing.JCheckBox ckbExtra;
    private com.toedter.calendar.JDateChooser jDFechaPartido;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPInputBox;
    private javax.swing.JPanel jPInputBox1;
    private javax.swing.JPanel jPInputBox2;
    private javax.swing.JPanel jPInputBox3;
    private javax.swing.JPanel jPInputBox4;
    private javax.swing.JPanel jPInputBox5;
    private javax.swing.JPanel jPInputBox6;
    private javax.swing.JPanel jPInputBox7;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTable jTBusca;
    private javax.swing.JTable jTLista;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JTextField txtBuscar;
    private javax.swing.JTextField txtCarrerasEquipoA;
    private javax.swing.JTextField txtCarrerasEquipoB;
    private javax.swing.JTextField txtIdJornada;
    private javax.swing.JTextField txtIdPartido;
    private javax.swing.JTextField txtNombreEquipoA;
    private javax.swing.JTextField txtNombreEquipoB;
    // End of variables declaration//GEN-END:variables
}
